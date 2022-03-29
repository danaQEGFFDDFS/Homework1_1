using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    
    public class Product
    {
        [Key]
        public int id_p { get; set; }
        public string color { get; set; }
        public int count_product { get; set; }
        public double size_product { get; set; }
        public double price { get; set; }
        
        [ForeignKey("id_b")]
        public virtual Brend Brend { get; set; }
       
        [ForeignKey(" id_type ")]
        public virtual type_Product Type_Product { get; set; }
      
    }
}
