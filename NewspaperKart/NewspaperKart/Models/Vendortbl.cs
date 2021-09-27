using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewspaperKart.Models
{
    public class Vendortbl
    {
        public int VendorId { get; set; }

        [Required(ErrorMessage = "Please add a Company Name")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Please enter email address")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid Email ID")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please add Phone number")]
        [StringLength(maximumLength: 10, MinimumLength = 10, ErrorMessage = "Phone number should be of 10 digits")]
        [Display(Name = "Phone Number")]
        public string Phoneno { get; set; }

        [Required(ErrorMessage = "Please add User name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please add Password")]
        public string Password { get; set; }
    }
}
