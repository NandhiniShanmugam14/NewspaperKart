using System;
using System.Collections.Generic;

#nullable disable

namespace SubscriptionAPI.CTSModel
{
    public partial class Newspapertbl
    {
        public Newspapertbl()
        {
            AddDeliverytbls = new HashSet<AddDeliverytbl>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }
        public string Price { get; set; }

        public virtual ICollection<AddDeliverytbl> AddDeliverytbls { get; set; }
    }
}
