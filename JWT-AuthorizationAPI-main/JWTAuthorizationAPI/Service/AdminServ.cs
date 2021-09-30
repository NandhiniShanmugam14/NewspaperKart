using JWTAuthorizationAPI.CTSModel;
using JWTAuthorizationAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuthorizationAPI.Service
{
    public class AdminServ : IAdminServ<Admintbl>
    {
        private readonly IAdminRepo<Admintbl> repo_a;
        public AdminServ(IAdminRepo<Admintbl> repo_a)
        {
            this.repo_a = repo_a;
        }
        public List<Admintbl> GetAdminCredentials()
        {
            return repo_a.GetAdminCredentials();
        }
    }
}
