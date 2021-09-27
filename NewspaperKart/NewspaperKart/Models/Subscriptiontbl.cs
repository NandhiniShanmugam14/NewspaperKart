using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewspaperKart.Models
{
    public class Subscriptiontbl
    {
        public int SubId { get; set; }
        public int CustId { get; set; }

        [Required(ErrorMessage = "Please enter the name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please select newspaper title")]
        public int TitleId { get; set; }

        [Required(ErrorMessage = "Please select the subscription type")]
        public string Subscriptiontype { get; set; }

        [Required(ErrorMessage = "Please select the time period")]
        public string Timeperiod { get; set; }

        public virtual Customertbl Cust { get; set; }
        public virtual Newspapertbl Title { get; set; }
    }
}
