using System;
using System.Collections.Generic;

#nullable disable

namespace SubscriptionAPI.CTSModel
{
    public partial class Paymenttbl
    {
        public int PayId { get; set; }
        public string Name { get; set; }
        public string CardNo { get; set; }
        public DateTime ExpDate { get; set; }
        public int Cvc { get; set; }
    }
}
