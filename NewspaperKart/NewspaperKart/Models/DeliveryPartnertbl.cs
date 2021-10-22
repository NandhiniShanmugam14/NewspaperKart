using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewspaperKart.Models
{
    public class DeliveryPartnertbl
    {
        public int DelPartId { get; set; }
        [Required(ErrorMessage = "Please Enter Name")]
        public string Name { get; set; }
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Please add Phone number")]
        [StringLength(maximumLength: 10, MinimumLength = 10, ErrorMessage = "Phone number should be of 10 digits")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string Phoneno { get; set; }
        [Required(ErrorMessage = "Please Enter Location")]
        public string Location { get; set; }
    }
}
