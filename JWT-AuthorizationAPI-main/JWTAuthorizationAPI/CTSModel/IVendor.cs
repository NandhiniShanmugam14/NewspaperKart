using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuthorizationAPI.CTSModel
{
    public interface IVendor<Vendortbl>
    {
        public List<Vendortbl> GetVendorCredentials();
    }
}
