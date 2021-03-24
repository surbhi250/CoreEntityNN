using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEntity.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Display(Name = "Purchase From ")]
        public string ShippingNo { get; set; }

        [Display(Name = "Price")]
        public int SerialNo { get; set; }

        [Display(Name = "Quantity")]
        public string BatchNo { get; set; }

    }
}
