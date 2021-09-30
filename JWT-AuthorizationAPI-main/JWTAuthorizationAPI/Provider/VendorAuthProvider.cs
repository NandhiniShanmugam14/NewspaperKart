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
    public class VendorAuthProvider : IVendorAuthProvider<Vendortbl>
    {
        private readonly IVendorServ<Vendortbl> ven_serv;
        public VendorAuthProvider(IVendorServ<Vendortbl> ven_serv)
        {
            this.ven_serv = ven_serv;
        }
        public string GenerateJSONWebToken(Vendortbl vendor_info, IConfiguration _config)
        {
            if (vendor_info == null)
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
        public dynamic AuthenticateUser(Vendortbl login)
        {
            if (login == null)
            {
                return null;
            }
            try
            {
                Vendortbl user = null;

                List<Vendortbl> ValidUsers = ven_serv.GetVendorCredentials();

                if (ValidUsers == null)
                    return null;
                else
                {
                    if (ValidUsers.Any(u => u.UserName == login.UserName && u.Password == login.Password))
                    {
                        user = new Vendortbl { UserName = login.UserName, Password = login.Password };
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
