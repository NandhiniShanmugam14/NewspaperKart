using JWTAuthorizationAPI.CTSModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuthorizationAPI.Repository
{
    public interface ICustomerRepo<Customer>
    {
        public List<Customertbl> GetCustomerCredentials();
    }
}
