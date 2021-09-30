using JWTAuthorizationAPI.CTSModel;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuthorizationAPI.Repository
{
    public class CustomerRepo : ICustomerRepo<Customertbl>
    {
        private readonly ICustomer<Customertbl> obj_c;
        public CustomerRepo(ICustomer<Customertbl> obj_c)
        {
            this.obj_c = obj_c;
        }

        public List<Customertbl> GetCustomerCredentials()
        {
            return obj_c.GetCustomerCredentials();
        }
    }
}
