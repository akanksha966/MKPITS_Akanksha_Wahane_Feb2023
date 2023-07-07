using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace dropdown2.Models
{
    public class CustomerDetails
    {

        [Required(ErrorMessage = "Enter Product Details")]
        public string Productcategory { get; set; }
        [Required(ErrorMessage = "Enter Product Type Name")]
        public string ProductName { get; set; }
    }
}