using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable

namespace JWTAuthorizationAPI.CTSModel
{
    public partial class Vendortbl:IVendor<Vendortbl>
    {
        private readonly NewspaperContext nc = new NewspaperContext();

        public int VendorId { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string Phoneno { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public List<Vendortbl> GetVendorCredentials()
        {
            return nc.Vendortbls.ToList();
        }
    }
}
