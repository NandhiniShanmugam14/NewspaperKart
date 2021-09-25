using System;
using System.Collections.Generic;

#nullable disable

namespace NewspaperKart.CTSModel
{
    public partial class Subscription
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubscriptionType { get; set; }
        public string TimePeriod { get; set; }
    }
}
