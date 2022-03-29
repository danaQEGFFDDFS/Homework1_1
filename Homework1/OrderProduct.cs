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
    public class OrderProduct
    {
        [Key]
        public int Id { get; set; }
        
        [ForeignKey("id_p")]
        public virtual Product Product { get; set; }
        //public String Productname { get; set; }
        
        [ForeignKey("id")]
        public virtual Order_shop Order_Shop { get; set; }
        //public string OrderNumber { get; set; }

        

        
    }
}
