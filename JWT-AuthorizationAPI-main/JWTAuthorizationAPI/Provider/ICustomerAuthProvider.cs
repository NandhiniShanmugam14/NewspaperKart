using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuthorizationAPI.Provider
{
    public interface ICustomerAuthProvider<Customertbl>
    {
        public string GenerateJSONWebToken(Customertbl customer_info, IConfiguration _config);
        public dynamic AuthenticateUser(Customertbl login);
    }
}
