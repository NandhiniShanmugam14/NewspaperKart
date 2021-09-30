using JWTAuthorizationAPI.CTSModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuthorizationAPI.Repository
{
    public class VendorRepo : IVendorRepo<Vendortbl>
    {
        private readonly IVendor<Vendortbl> obj_e;
        public VendorRepo(IVendor<Vendortbl> obj_e)
        {
            this.obj_e = obj_e;
        }

        public List<Vendortbl> GetVendorCredentials()
        {
            return obj_e.GetVendorCredentials();
        }
    }
}
