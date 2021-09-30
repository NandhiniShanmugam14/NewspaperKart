using JWTAuthorizationAPI.CTSModel;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuthorizationAPI.Provider
{
    public interface IAdminAuthProvider<Admintbl>
    {
        public string GenerateJSONWebToken(CTSModel.Admintbl admin_info, IConfiguration _config);
        public dynamic AuthenticateUser(CTSModel.Admintbl login);
    }
}
