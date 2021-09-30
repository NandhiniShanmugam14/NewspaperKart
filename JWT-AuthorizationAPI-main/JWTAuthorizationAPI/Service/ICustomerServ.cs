using JWTAuthorizationAPI.CTSModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuthorizationAPI.Service
{
    public interface ICustomerServ<Customer>
    {
        public List<Customertbl> GetCustomerCredentials();
    }
}
