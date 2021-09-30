using JWTAuthorizationAPI.CTSModel;
using JWTAuthorizationAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuthorizationAPI.Service
{
    public class VendorServ : IVendorServ<Vendortbl>
    {
        private readonly IVendorRepo<Vendortbl> repo_e;
        public VendorServ(IVendorRepo<Vendortbl> repo_e)
        {
            this.repo_e = repo_e;
        }

        public List<Vendortbl> GetVendorCredentials()
        {
            return repo_e.GetVendorCredentials();
        }
    }
}
