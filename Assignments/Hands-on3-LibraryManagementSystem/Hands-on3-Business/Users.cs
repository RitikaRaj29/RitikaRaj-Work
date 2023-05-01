using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hands_on3_DataAccess;
using Hands_on3_Entities;

namespace Hands_on3_Business
{
    public class Users
    {
        DataAccess DA = new DataAccess();


        public bool CheckGeneral(string name, string password)
        {
            List<UserData> b = DA.getUser();
            foreach (var ad in b)
                if (name.Equals(ad.username) && password.Equals(ad.password))
                    return true;
            return false;
        }

        public void General()
        {
            Console.WriteLine("\n\n===============WELCOME TO THE USER SECTION===============");
            int choice;
            do
            {
                Console.WriteLine("\nEnter your choice:\n1. Sign-up\n2. Log-in\n3. Exit");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        UserData u = new UserData();

                        Console.Write("\nEnter your name: ");
                        u.name = Console.ReadLine();

                        Console.Write("Enter your phone number: ");
                        u.phoneNumber = long.Parse(Console.ReadLine());

                        Console.Write("Enter your username: ");
                        u.username = Console.ReadLine();

                        Console.Write("Enter your password: ");
                        u.password = Console.ReadLine();

                        Console.Write("Confirm password: ");
                        string confirmPassword = Console.ReadLine();

                        if (!u.password.Equals(confirmPassword))
                        {
                            Console.WriteLine("\n\nPasswords don't match!!! Try Again!!!\n");
                            break;
                        }

                        DA.AddUser(u);
                        Console.WriteLine("\n\nYou have successfully signed up!!!\n");

                        break;
                    case 2:
                        Console.Write("\nEnter your username: ");
                        string username = Console.ReadLine();

                        Console.Write("Enter your password: ");
                        string password = Console.ReadLine();

                        if (CheckGeneral(username, password))
                        {
                            Console.WriteLine("\n\nYou have successfully logged in.");
                            GeneralLoggedIn();
                        }
                        else
                            Console.WriteLine("\nInvalid credentials!!! Try Again!!!");
                        break;
                    case 3:
                        Console.WriteLine("\n========YOU HAVE EXITED THE USER SECTION========\n");
                        break;
                    default:
                        Console.WriteLine("\nInvalid Choice.");
                        break;
                }
            } while (choice != 3);
        }
        void GeneralLoggedIn()
        {
            int choice;
            Console.WriteLine("\nYou can search a book by its author, book name or category.\nYou can place a request to reserve or return a book\n");
            do
            {
                Console.WriteLine("\n\nEnter your choice:\n1. Display the list of books\n2. Search for a book\n3. Reserve a book\n4. Return a book\n5. Exit");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
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

                    case 2:
                        // search the book list
                        DA.Search();
                        break;
                    case 3:
                        // reserve request
                        List<BookData> books = DA.getBooks();
                        int flag = 0;
                        int count;
                        Console.WriteLine("\nEnter the Name of the book you want to reserve:");
                        string name = Console.ReadLine();
                        foreach (var bo in books)
                        {
                            if (name.Equals(bo.BookName))
                                flag = 1;
                        }
                        if (flag == 0)
                        {
                            Console.WriteLine("\nBook not found!!!");
                        }
                        else
                        {
                            count = DA.reserveBook(name);
                            if(count!=0)
                                Console.WriteLine("\nBook has been requested, records affected : "+count);
                            else
                                Console.WriteLine("\nRequested reservation is not possible");
                        }
                        break;
                    case 4:
                        // return request
                        int count1;
                        Console.WriteLine("\nEnter the Name of the book you want to return:");
                        string name1 = Console.ReadLine();
                        count1 = DA.returnBook(name1);
                        if (count1 != 0)
                            Console.WriteLine("\nBook has been returned, records affected : " + count1);
                        break;
                    case 5:
                        Console.WriteLine("\n===========YOU HAVE EXITED THE MENU===========\n");
                        break;
                    default:
                        Console.WriteLine("\nInvalid choice");
                        break;
                }
            } while (choice != 5);

        }
    }
}
