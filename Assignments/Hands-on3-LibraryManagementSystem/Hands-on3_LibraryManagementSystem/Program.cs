using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hands_on3_Business;
using Hands_on3_DataAccess;
using Hands_on3_Entities;

namespace Hands_on3_LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataAccess DA = new DataAccess();
            Admins a = new Admins();
            Users gen = new Users();
            //DA.setAdmin();
            //DA.setBook();
            //DA.setUser();
            int choice;
            Console.WriteLine("\n\n===============WELCOME TO SOUTH PARK LIBRARY===============\n");
            do
            {
                Console.WriteLine("Enter your choice:\n1. Admin\n2. User\n3. Exit");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        // call admin function to get the details of admin
                        a.Admin();
                        break;
                    case 2:
                        // call general function to get the details of general
                        gen.General();
                        break;
                    case 3:
                        Console.WriteLine("\n============HOPE YOU ENJOYED YOUR STAY============");
                        Console.WriteLine("============THANK YOU AND VISIT AGAIN============\n");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (choice != 3);
        }
    }
}
