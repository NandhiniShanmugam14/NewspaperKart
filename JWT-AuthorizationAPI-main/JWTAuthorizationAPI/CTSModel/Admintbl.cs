using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable

namespace JWTAuthorizationAPI.CTSModel
{
    public partial class Admintbl:IAdmin<Admintbl>
    {
        private readonly NewspaperContext nc = new NewspaperContext();
        public int AdminId { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public List<Admintbl> GetAdminCredentials()
        {
            return nc.Admintbls.ToList();
        }
    }
}
