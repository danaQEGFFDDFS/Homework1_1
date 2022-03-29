using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;



namespace Homework1
{
    internal class Program
    {
        

        private static ShopContext context = new ShopContext();

         private static void ADdNewCustom() {
              Customers customer = new Customers
              {
                  id_cust = 1, fullname = "Нургазиева Дана Руслановна", phone = 89371234567, address = "г. Москва, ул. Ленина 4, кв.51" };
              Customers customer1 = new Customers
              {
                  id_cust = 2,
                  fullname = "Егоров Антон Антонович",
                  phone = 89271234347,
                  address = "г. Москва, ул. Павлова 32, кв.17"
              };
              Customers customer2 = new Customers
              {
                  id_cust = 3,
                  fullname = "Звонкая Алина Алексеевна",
                  phone = 89651385467,
                  address = "г. Москва, ул. Вершинина 12, кв.21"
              };
              Customers customer3 = new Customers
              {
                  id_cust = 3,
                  fullname = "Маринина Альбина Романовна",
                  phone = 89171553425,
                  address = "г. Москва, ул. Сухого 12 к.1, кв.37"
              };
          }
        public static double Oddss(string Number)
        {
            int totalCount = (from part in context.order_Shops
                              where part.OrderProduct.== Number
                              select part).Count();
            return 0;

        }
        List<Order_shop> total = (from part in context.order_Shops
                                  where part.current_data >= DateTime.MaxValue
                                  select part).ToList();
        List<string> secondname = context.Customers.Select(c => c.fullname).ToList();


        static void Main(string[] args)
        {
          using (ShopContext context = new ShopContext())
            {
                
                Brend brend1 = new Brend { id_b = 11, name = "Gucci" };
                Brend brend2 = new Brend { id_b = 12, name = "Prada" };
                Brend brend3 = new Brend { id_b = 13, name = "Burberry" };
                Brend brend4 = new Brend { id_b = 14, name = "Chanel" };
                context.Brends.Add(brend1);
                context.Brends.Add(brend2);
                context.Brends.Add(brend3);
                context.Brends.Add(brend4);
                context.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");
                var brends = context.Brends.ToList();
                Console.WriteLine("Список объектов:");
                foreach (Brend u in brends)
                {
                    Console.WriteLine($"{u.id_b}. {u.name}");
                }

               

            }
          
            Console.Read();
            context.Database.EnsureCreated();
        }
    }
}
