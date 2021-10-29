using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewspaperKart.Models
{
    public class AddDeliverytbl
    {
        public int DelId { get; set; }
        public string CustName { get; set; }
        public string Title { get; set; }
        public string Timeperiod { get; set; }
        public string DelPartner { get; set; }
    }
}
