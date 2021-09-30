using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuthorizationAPI.Provider
{
    public interface IVendorAuthProvider<Vendortbl>
    {
        public string GenerateJSONWebToken(Vendortbl vendor_info, IConfiguration _config);
        public dynamic AuthenticateUser(Vendortbl login);
    }
}
