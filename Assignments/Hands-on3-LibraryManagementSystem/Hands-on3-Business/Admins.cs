using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hands_on3_DataAccess;
using Hands_on3_Entities;

namespace Hands_on3_Business
{
    public class Admins
    {
        DataAccess DA = new DataAccess();
        public bool CheckAdmin(string name, string password)
        {
            List<AdminData> b = DA.getAdmin();
            foreach (var ad in b)
                if (name.Equals(ad.username) && password.Equals(ad.password))
                    return true;
            return false;
        }

        public void Admin()
        {
            Console.WriteLine("\n\n===============WELCOME TO THE ADMIN SECTION===============");
            int choice;
            do
            {
                Console.WriteLine("\nEnter your choice:\n1. Log-in\n2. Exit");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("\nEnter your username: ");
                        string username = Console.ReadLine();

                        Console.Write("Enter your password: ");
                        string password = Console.ReadLine();

                        if (CheckAdmin(username, password))
                        {
                            Console.WriteLine("\n\nYou have successfully logged in.");
                            AdminLoggedIn();
                        }
                        else
                            Console.WriteLine("\nInvalid credentials!!! Try Again!!!");
                        break;
                    case 2:
                        Console.WriteLine("\n========YOU HAVE EXITED THE ADMIN SECTION========\n");
                        break;
                    default:
                        Console.WriteLine("\nInvalid Choice.");
                        break;
                }
            } while (choice != 2);
        }
        public void AdminLoggedIn()
        {
            int choice;
            Console.WriteLine("\nYou can search a book by its author, book name or category.\nYou can also reserve or return a book for a customer\n");
            do
            {
                Console.WriteLine("\n\nEnter your choice:\n1. Add a book in the library\n2. Display the list of books\n3. Search for a book\n4. Check the Order list\n5. Check the return list\n6. Exit");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        try
                        {
                            int count = DA.AddBook();
                            Console.WriteLine("\nBook Added successfully, {0} records afffected", count);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 2:
                        // show the book list
                        List<BookData> b = DA.ShowList();
                        if (b == null)
                            Console.WriteLine("\nNo record found!!!");
                        else
                        {
                            Console.WriteLine("\nBook Id\t\tAuthor\t\t\tTitle\t\t\tCategory\t\tQuantity\n");
                            foreach (BookData book in b)
                            {
                                Console.WriteLine(String.Format("{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}", book.Id, book.AuthorName, book.BookName, book.Category, book.Quantity));
                            }
                        }
                        break;

                    case 3:
                        DA.Search();
                        
                        break;
                    case 4:
                        // reserve
                        DA.reserveAdmin();
                        break;
                    case 5:
                        // return request
                        DA.returnAdmin();
                        break;
                    case 6:
                        Console.WriteLine("\n===========YOU HAVE EXITED THE MENU===========\n");
                        break;
                    default:
                        Console.WriteLine("\nInvalid choice");
                        break;
                }
            } while (choice != 6);
        }
    }
}
