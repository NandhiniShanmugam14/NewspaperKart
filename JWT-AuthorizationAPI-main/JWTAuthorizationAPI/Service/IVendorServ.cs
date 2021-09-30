using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuthorizationAPI.Service
{
    public interface IVendorServ<Vendortbl>
    {
        public List<Vendortbl> GetVendorCredentials();
    }
}
