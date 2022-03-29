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
   public  class ShopContext:DbContext
    {
       public  DbSet<Brend> Brends { get; set; }
        public  DbSet<Product> Products { get; set; }
        public DbSet<Order_shop> order_Shops { get; set; }
        public DbSet<type_Product> type_Products { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Homework1Db;Trusted_Connection=True;");
        }
    }
}
