using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NewspaperKart.Models
{
    public class Admintbl
    {
        public int AdminId { get; set; }

        [Required(ErrorMessage = "Please add a Name")]
        public string Name { get; set; }

        //[Remote(action: "IsUserNameAvailable", controller: "Admin")]
        [Required(ErrorMessage = "Please add a Username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter a Password")]
        public string Password { get; set; }
    }
}
