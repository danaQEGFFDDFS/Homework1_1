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
    public class Order_shop
    {
        [Key]
     
        public int id { get; set; }
        public DateTime current_data { get; set; }
       
        [ForeignKey("id_p")]
        public virtual Product Product { get; set; }
        
        [ForeignKey("id_cust")]
        public virtual Customers Customers { get; set; }
        
        [ForeignKey("Id")]
        public virtual OrderProduct OrderProduct { get; set; }
    }
}
