using System;
using System.Collections.Generic;

#nullable disable

namespace CustomerAPI.CTSModel
{
    public partial class Customertbl
    {
        public Customertbl()
        {
            AddDeliverytbls = new HashSet<AddDeliverytbl>();
            Feedbacktbls = new HashSet<Feedbacktbl>();
            Subscriptiontbls = new HashSet<Subscriptiontbl>();
        }

        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phoneno { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public virtual ICollection<AddDeliverytbl> AddDeliverytbls { get; set; }
        public virtual ICollection<Feedbacktbl> Feedbacktbls { get; set; }
        public virtual ICollection<Subscriptiontbl> Subscriptiontbls { get; set; }
    }
}
