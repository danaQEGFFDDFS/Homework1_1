using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Homework1
{
     public class Customers
    { 
        [Key]
        public int id_cust { get; set; }
        public string fullname { get; set; }
        public long phone { get; set; }
        public string address { get; set; }

    }
}
