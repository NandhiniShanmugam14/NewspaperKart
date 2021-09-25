using System;
using System.Collections.Generic;

#nullable disable

namespace NewspaperAPI.CTSModel
{
    public partial class DeliveryPartnertbl
    {
        public DeliveryPartnertbl()
        {
            AddDeliverytbls = new HashSet<AddDeliverytbl>();
        }

        public int DelPartId { get; set; }
        public string Name { get; set; }
        public string Phoneno { get; set; }
        public string Location { get; set; }

        public virtual ICollection<AddDeliverytbl> AddDeliverytbls { get; set; }
    }
}
