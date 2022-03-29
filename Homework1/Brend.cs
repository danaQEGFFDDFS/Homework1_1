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
    public class Brend
    {
     [Key]
     public int id_b { get; set; }
     public string name { get; set; }

    }
}
