using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuthorizationAPI.Repository
{
    public interface IVendorRepo<Vendortbl>
    {
        public List<Vendortbl> GetVendorCredentials();
    }
}
