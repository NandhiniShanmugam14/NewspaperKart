using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewspaperKart.Models
{
    public class AddDeliverytbl
    {
        public int DelId { get; set; }
        public int Custid { get; set; }
        public int Titleid { get; set; }
        public string Phoneno { get; set; }
        public int DelpartId { get; set; }

        public virtual Customertbl Cust { get; set; }
        public virtual DeliveryPartnertbl Delpart { get; set; }
        public virtual Newspapertbl Title { get; set; }
    }
}
