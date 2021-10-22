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
        public int Custid { get; set; }
        public int Titleid { get; set; }

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Please add Phone number")]
        [StringLength(maximumLength: 10, MinimumLength = 10, ErrorMessage = "Phone number should be of 10 digits")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string Phoneno { get; set; }

        [Required(ErrorMessage = "Please enter id")]
        public int DelpartId { get; set; }

        public virtual Customertbl Cust { get; set; }
        public virtual DeliveryPartnertbl Delpart { get; set; }
        public virtual Newspapertbl Title { get; set; }
    }
}
