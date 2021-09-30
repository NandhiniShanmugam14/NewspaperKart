using JWTAuthorizationAPI.CTSModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuthorizationAPI.Repository
{
    public interface IAdminRepo<Admin>
    {
        public List<Admintbl> GetAdminCredentials();
    }
}
