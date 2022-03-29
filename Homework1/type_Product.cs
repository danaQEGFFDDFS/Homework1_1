using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Homework1
{
   public  class type_Product
    { 
        [Key]
        public int id_type { get; set; }
        public string namee { get; set; }
        public string image { get; set; }
    }
}
