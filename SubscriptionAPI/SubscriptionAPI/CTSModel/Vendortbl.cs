using System;
using System.Collections.Generic;

#nullable disable

namespace SubscriptionAPI.CTSModel
{
    public partial class Vendortbl
    {
        public int VendorId { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string Phoneno { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
