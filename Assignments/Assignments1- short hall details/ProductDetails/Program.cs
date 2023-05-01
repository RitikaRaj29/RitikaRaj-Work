using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> pro = new List<Product>();

            Console.WriteLine("Product Id  " + "Brand Name   " + " Description      " + " Price ");

            pro.Add(new Product { ProductID = 200, BrandName = "         Dell ", Description = "        15 inch Monitor  ",  Price = 3400.44 });


            pro.Add(new Product { ProductID = 100, BrandName = "         Logitech ", Description = "    Optical Mouse    ",  Price = 540.00 });
            pro.Add(new Product { ProductID = 150, BrandName = "         Microsoft", Description = "    Windows 7        ",  Price = 7000.50 });
            pro.Add(new Product { ProductID = 120, BrandName = "         Dell ", Description = "        Laptop           ",  Price = 45000.00 });

            pro.Sort();
            DisplayPro(pro);
            Console.ReadLine();

            Console.WriteLine("sorted by brand name or description ");
            pro.Sort(new SortByBrandName());
            DisplayPro(pro);
            Console.ReadLine();

            Console.WriteLine("sorted by price or product id ");
            pro.Sort(new SortByPrice());
            DisplayPro(pro);
            Console.ReadLine();





        }



        private static void DisplayPro(IList<Product> pro)
        {
            for (int i = 0; i < pro.Count; i++)
            {
                Console.WriteLine(pro[i].ProductID + pro[i].BrandName + pro[i].Description + pro[i].Price);



            }
        }


    }


}

