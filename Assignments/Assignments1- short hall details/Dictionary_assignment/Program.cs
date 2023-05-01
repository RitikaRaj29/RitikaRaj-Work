using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_assignment
{
    internal class Program
    {
        
        static void Main(string[] args)
        {


            Dictionary<int, Company> company = new Dictionary<int, Company>();
            Console.WriteLine("enter the no of companies: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter the details of company :");
                string CName = Console.ReadLine();
                int NoOfOffers = int.Parse(Console.ReadLine());


                company.Add(new Company(CName, NoOfOffers));
            }

            int c = 0;
            c = company.Keys.First();
            int max = c;
            foreach (var k in company.Keys)
            {
                if (k > max)
                    max = k;
            }
            Console.WriteLine("company with maximum recruitments : " + company[max]);
        }
       




    }
}
