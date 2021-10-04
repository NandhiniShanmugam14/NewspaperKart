using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewspaperKart.Models
{
    public class Feedbacktbl
    {
        public int FeedId { get; set; }

        [Required(ErrorMessage = "Please Enter Customer Id")]
        public int CustId { get; set; }

        [Required(ErrorMessage = "Please enter Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter email address")]
        public string Email { get; set; }

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Please add Phone number")]
        [StringLength(maximumLength: 10, MinimumLength = 10, ErrorMessage = "Phone number should be of 10 digits")]
        public string Phoneno { get; set; }

        [Required(ErrorMessage = "Please select newspaper title")]
        public int TitleId { get; set; }

        [Required(ErrorMessage = "Please enter your problem")]
        public string Issue { get; set; }

        public virtual Customertbl Cust { get; set; }
        public virtual Newspapertbl Title { get; set; }
    }
}
