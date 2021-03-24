using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEntity.Models
{
    public class Purchase
    {
        public int Id { get; set; }

        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [Display(Name = "Contact ")]
        public string Contact { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }


        [Display(Name = "Product Name")]
        public String ProductName { get; set; }


        [Display(Name = "Bill")]
        public int Bill { get; set; }

    }
}
