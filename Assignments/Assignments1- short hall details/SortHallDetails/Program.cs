using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortHallDetails
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List <Hall> h=new List<Hall>();
            Hall h1 = new Hall();
            Console.WriteLine("enter total number of halls ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter hall details ");

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                long mobileNo = System.Convert.ToInt64(Console.ReadLine());
                string ownerName = Console.ReadLine();
                double costPerDay = System.Convert.ToDouble(Console.ReadLine());
                h.Add(new Hall(name, mobileNo, ownerName, costPerDay));

                
            }
            h.Sort();
            h1.Displayh(h);

            

        }
        
    }
}
