using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewspaperKart.Models
{
    public class Subscriptiontbl
    {
        public int SubId { get; set; }
        public int CustId { get; set; }
        public string Name { get; set; }
        public int TitleId { get; set; }
        public string Subscriptiontype { get; set; }
        public string Timeperiod { get; set; }

        public virtual Customertbl Cust { get; set; }
        //public virtual Newspapertbl Title { get; set; }
    }
}
