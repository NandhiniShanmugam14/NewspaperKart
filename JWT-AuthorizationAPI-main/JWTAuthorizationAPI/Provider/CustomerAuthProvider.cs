using JWTAuthorizationAPI.CTSModel;
using JWTAuthorizationAPI.Service;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWTAuthorizationAPI.Provider
{
    public class CustomerAuthProvider : ICustomerAuthProvider<Customertbl>
    {
        private readonly ICustomerServ<Customertbl> cus_serv;
        public CustomerAuthProvider(ICustomerServ<Customertbl> cus_serv)
        {
            this.cus_serv = cus_serv;
        }
        public string GenerateJSONWebToken(Customertbl customer_info, IConfiguration _config)
        {
            if (customer_info == null)
                return null;
            try
            {
                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));

                var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(_config["Jwt:Issuer"],
                    _config["Jwt:Issuer"],
                    null,
                    expires: DateTime.Now.AddMinutes(100),
                    signingCredentials: credentials);

                return new JwtSecurityTokenHandler().WriteToken(token);
            }
            catch (Exception)
            {
                return null;
            }

        }
        public dynamic AuthenticateUser(Customertbl login)
        {
            if (login == null)
            {
                return null;
            }
            try
            {
                Customertbl user = null;

                List<Customertbl> ValidUsers = cus_serv.GetCustomerCredentials();

                if (ValidUsers == null)
                    return null;
                else
                {
                    if (ValidUsers.Any(u => u.UserName == login.UserName && u.Password == login.Password))
                    {
                        user = new Customertbl { UserName = login.UserName, Password = login.Password };
                    }
                }

                return user;
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
