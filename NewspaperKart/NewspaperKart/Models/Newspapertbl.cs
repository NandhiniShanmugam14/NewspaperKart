using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewspaperKart.Models
{
    public class Newspapertbl
    {
        public Newspapertbl()
        {
            //AddDeliverytbls = new HashSet<AddDeliverytbl>();
            Feedbacktbls = new HashSet<Feedbacktbl>();
            Subscriptiontbls = new HashSet<Subscriptiontbl>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Please add a Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please add the Language")]
        public string Language { get; set; }

        [Required(ErrorMessage = "Please add the Price")]
        public string Price { get; set; }

        //public virtual ICollection<AddDeliverytbl> AddDeliverytbls { get; set; }
        public virtual ICollection<Feedbacktbl> Feedbacktbls { get; set; }
        public virtual ICollection<Subscriptiontbl> Subscriptiontbls { get; set; }
    }
}
