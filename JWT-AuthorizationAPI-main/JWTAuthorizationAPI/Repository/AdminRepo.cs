using JWTAuthorizationAPI.CTSModel;
using Microsoft.PowerBI.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuthorizationAPI.Repository
{
    public class AdminRepo : IAdminRepo<Admintbl>
    {
        private readonly IAdmin<Admintbl> obj_a;
        public AdminRepo(IAdmin<Admintbl> obj_a)
        {
            this.obj_a = obj_a;
        }
        public List<Admintbl> GetAdminCredentials()
        {
            return obj_a.GetAdminCredentials();
        }
    }
}
