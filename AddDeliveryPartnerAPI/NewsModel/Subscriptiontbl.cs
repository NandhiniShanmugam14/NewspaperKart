using System;
using System.Collections.Generic;

#nullable disable

namespace AddDeliveryPartner.NewsModel
{
    public partial class Subscriptiontbl
    {
        public int SubId { get; set; }
        public int CustId { get; set; }
        public string Name { get; set; }
        public string Subscriptiontype { get; set; }
        public string Timeperiod { get; set; }
        public string Title { get; set; }

        public virtual Customertbl Cust { get; set; }
    }
}
