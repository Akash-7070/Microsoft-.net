using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcSchemaFIrst.Models
{
    public class Product
    {
        public int id { get; set; }
        [Required(ErrorMessage="Enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage="Enter Price")]
        public float Price { get; set; }
        [Required(ErrorMessage="Enter Qty")]
        public int Qty { get; set; }

    }
}