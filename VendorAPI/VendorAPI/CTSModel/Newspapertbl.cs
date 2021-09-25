using System;
using System.Collections.Generic;

#nullable disable

namespace VendorAPI.CTSModel
{
    public partial class Newspapertbl
    {
        public Newspapertbl()
        {
            AddDeliverytbls = new HashSet<AddDeliverytbl>();
            Feedbacktbls = new HashSet<Feedbacktbl>();
            Subscriptiontbls = new HashSet<Subscriptiontbl>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }
        public string Price { get; set; }

        public virtual ICollection<AddDeliverytbl> AddDeliverytbls { get; set; }
        public virtual ICollection<Feedbacktbl> Feedbacktbls { get; set; }
        public virtual ICollection<Subscriptiontbl> Subscriptiontbls { get; set; }
    }
}
