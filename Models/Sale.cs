using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEntity.Models
{
    public class Sale
    {
        public int Id { get; set; }

        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }

        [Display(Name = "Contact ")]
        public string Contact { get; set; }

        [Display(Name = "Product Name")]
        public String ProductName { get; set; }

        [Display(Name = "Price")]
        public int Price { get; set; }

        [Display(Name = "Quantity")]
        public int Qty { get; set; }


        [Display(Name = "Bill")]
        public int Bill { get; set; }
    }
}
