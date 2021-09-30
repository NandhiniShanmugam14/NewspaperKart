using JWTAuthorizationAPI.CTSModel;
using JWTAuthorizationAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuthorizationAPI.Service
{
    public class CustomerServ : ICustomerServ<Customertbl>
    {
        private readonly ICustomerRepo<Customertbl> repo_c;
        public CustomerServ(ICustomerRepo<Customertbl> repo_c)
        {
            this.repo_c = repo_c;
        }

        public List<Customertbl> GetCustomerCredentials()
        {
            return repo_c.GetCustomerCredentials();
        }
    }
}
