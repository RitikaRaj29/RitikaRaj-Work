using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hands_on3_Entities;
using System.Data.SqlClient; //for ADO.Net classes
using System.Data;

namespace Hands_on3_DataAccess
{
    public class DataAccess
    {
        SqlConnection con;

        public DataAccess()
        {
            //1.configure the connection
            con = new SqlConnection();
            //con.ConnectionString =@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalogue=CGDB;Integrated Security=True;";

            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CGDB;Integrated Security=True;";
        }

        /*static List<Reserve> res = new List<Reserve>();
        static List<Return> ret = new List<Return>();
        static List<UserData> u = new List<UserData>();
        static List<BookData> b = new List<BookData>();
        static List<AdminData> a = new List<AdminData>();

        public void setUser()
        {
            u.Add(new UserData { username = "ruchit", password = "170500", name = "Ruchit", phoneNumber = 12345 });
            u.Add(new UserData { username = "rajdeep", password = "abcdef", name = "Rajdeep", phoneNumber = 78906 });
            u.Add(new UserData { username = "ritika", password = "lmno", name = "Ritika", phoneNumber = 45678 });
            u.Add(new UserData { username = "ridhima", password = "qwerty", name = "Ridhima", phoneNumber = 34567 });
            u.Add(new UserData { username = "sagnik", password = "andjemfd", name = "Sagnik", phoneNumber = 482912 });
        }

        public void setBook()
        {
            b.Add(new BookData { Id = 101, AuthorName = "Shakespeare", BookName = "As You Like It", Category = "Literature", Quantity = 10 });
            b.Add(new BookData { Id = 101, AuthorName = "Shakespeare", BookName = "Julius Ceaser", Category = "Literature", Quantity = 10 });
            b.Add(new BookData { Id = 102, AuthorName = "Chetan Bhagat", BookName = "Two States", Category = "Novel Book", Quantity = 10 });
            b.Add(new BookData { Id = 102, AuthorName = "Charles Dickens", BookName = "Oliver Twist", Category = "Novel Book", Quantity = 10 });
            b.Add(new BookData { Id = 102, AuthorName = "J.K. Rowling", BookName = "Harry Potter", Category = "Novel Book", Quantity = 10 });
            b.Add(new BookData { Id = 103, AuthorName = "John Skeet", BookName = "C# in Depth", Category = "Info. Tech.", Quantity = 10 });
            b.Add(new BookData { Id = 103, AuthorName = "Andrew Stellman", BookName = "Head First C#", Category = "Info. Tech.", Quantity = 10 });
        }

        public void setAdmin()
        {
            a.Add(new AdminData { username = "ruchit", password = "170500", name = "Ruchit", phoneNumber = 12345 });
            a.Add(new AdminData { username = "rajdeep", password = "abcdef", name = "Rajdeep", phoneNumber = 78906 });
            a.Add(new AdminData { username = "ritika", password = "lmno", name = "Ritika", phoneNumber = 45678 });
            a.Add(new AdminData { username = "ridhima", password = "qwerty", name = "Ridhima", phoneNumber = 34567 });
            a.Add(new AdminData { username = "sagnik", password = "andjemfd", name = "Sagnik", phoneNumber = 482912 });
        }*/

        public List<UserData> getUser()
        {
            List<UserData> u = new List<UserData>();
            //2.Get the book details by value
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [USER]";
            //3.Attach the connection with command
            cmd.Connection = con;
            //4. Open connection and execute command
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                UserData b = new UserData
                {
                    username = reader[0].ToString(),
                    password = reader[1].ToString(),
                    name = reader[2].ToString(),
                    phoneNumber = (int)reader[3]
                };
                //5.Add record to colection
                u.Add(b);
            }
            //6.Close the reader
            reader.Close();
            //7.Close the connection
            con.Close();
            //8.Return the collection
            return u;
        }

        public List<BookData> getBooks()
        {
            List<BookData> book = new List<BookData>();
            //2.Get the book details by value
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from BOOK";
            //3.Attach the connection with command
            cmd.Connection = con;
            //4. Open connection and execute command
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                BookData b = new BookData
                {
                    Id = (int)reader[0],
                    AuthorName = reader[1].ToString(),
                    BookName = reader[2].ToString(),
                    Category = reader[3].ToString(),
                    Quantity = (int)reader[4]
                };
                //5.Add record to colection
                book.Add(b);
            }
            //6.Close the reader
            reader.Close();
            //7.Close the connection
            con.Close();
            //8.Return the collection
            return book;
        }

        public List<AdminData> getAdmin()
        {
            List<AdminData> a = new List<AdminData>();
            //2.Get the book details by value
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from ADMIN";
            //3.Attach the connection with command
            cmd.Connection = con;
            //4. Open connection and execute command
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                AdminData b = new AdminData
                {
                    username = reader[0].ToString(),
                    password = reader[1].ToString(),
                    name = reader[2].ToString(),
                    phoneNumber = (int)reader[3]
                };
                //5.Add record to colection
                a.Add(b);
            }
            //6.Close the reader
            reader.Close();
            //7.Close the connection
            con.Close();
            //8.Return the collection
            return a;
        }

        public List<Reserve> getReserve()
        {
            List<Reserve> res = new List<Reserve>();
            //2.Get the book details by value
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from RESERVE";
            //3.Attach the connection with command
            cmd.Connection = con;
            //4. Open connection and execute command
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Reserve b = new Reserve
                {
                    BookName = reader[0].ToString()
                };
                //5.Add record to colection
                res.Add(b);
            }
            //6.Close the reader
            reader.Close();
            //7.Close the connection
            con.Close();
            //8.Return the collection
            return res;
        }

        public List<Return> getReturn()
        {
            List<Return> ret = new List<Return>();
            //2.Get the book details by value
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [RETURN]";
            //3.Attach the connection with command
            cmd.Connection = con;
            //4. Open connection and execute command
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Return b = new Return
                {
                    BookName = reader[0].ToString()
                };
                //5.Add record to colection
                ret.Add(b);
            }
            //6.Close the reader
            reader.Close();
            //7.Close the connection
            con.Close();
            //8.Return the collection
            return ret;
        }

        public void Search()
        {
            Console.WriteLine("\nEnter the Author/Title/Category of the book:");
            string detail = Console.ReadLine();
            //List<BookData> book = DA.Search(detail);
            /*if (book != null)
            {
                Console.WriteLine("\nThis book is available\n");
                Console.WriteLine("\nBook Id\t\tAuthor\t\t\tTitle\t\t\tCategory\t\tQuantity\n");
                foreach (var b in book)
                {
                    Console.WriteLine(String.Format("{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}", b.Id, b.AuthorName, b.BookName, b.Category, b.Quantity));
                }
            }
            else
                Console.WriteLine("\nThis book isn't available");*/
            List<BookData> book = new List<BookData>();
            try
            {
                //2.Get the book details by value
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from BOOK where Author like '%' + @det + '%' or BookName like '%' + @det + '%' or Category like '%' + @det + '%'";
                //3.Specify the parameter
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@det", detail);
                //4.Attach the connection with command
                cmd.Connection = con;
                //5. Open connection and execute command
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    BookData b = new BookData
                    {
                        Id = (int)reader[0],
                        AuthorName = reader[1].ToString(),
                        BookName = reader[2].ToString(),
                        Category = reader[3].ToString(),
                        Quantity = (int)reader[4]
                    };
                    //6.Add record to colection
                    book.Add(b);
                }
                if(book.Count == 0)  
                    throw new Exception("\nno record found!!!");
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //8.Close the connection
                con.Close();
            }
            if (book.Count == 0)
            {
                Console.WriteLine("\nThis book isn't available");
            }
            else
            {
                Console.WriteLine("\nThis book is available\n");
                Console.WriteLine("\nBook Id\t\tAuthor\t\t\tTitle\t\t\tCategory\t\tQuantity\n");
                foreach (var b in book)
                {
                    Console.WriteLine(String.Format("{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}", b.Id, b.AuthorName, b.BookName, b.Category, b.Quantity));
                }
            }

            //else
            //Console.WriteLine("\nThis book isn't available");
        }

        public int AddBook()
        {
            BookData book = new BookData();
            Console.WriteLine("\nEnter the Id of the book : ");
            book.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the author's name : ");
            book.AuthorName = Console.ReadLine();
            Console.WriteLine("Enter the book name : ");
            book.BookName = Console.ReadLine();
            Console.WriteLine("Enter the category of the book : ");
            book.Category = Console.ReadLine();
            Console.WriteLine("Enter the quantity of the books : ");
            book.Quantity = int.Parse(Console.ReadLine());
            int recordsAffected = 0;
            try
            {
                //INSERT OPERATION
                //2.Configure the Sql Command for INSERT
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                //3.Specify the command text for INSERT
                cmd.CommandText = "insert into BOOK values(@bi,@an,@bn,@cat,@quan)";
                //4.Specify the values for the parameters
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@bi", book.Id);
                cmd.Parameters.AddWithValue("@an", book.AuthorName);
                cmd.Parameters.AddWithValue("@bn", book.BookName);
                cmd.Parameters.AddWithValue("@cat", book.Category);
                cmd.Parameters.AddWithValue("@quan", book.Quantity);
                //5.Open the connection
                con.Open();
                //6. Attach the connecton with the command
                cmd.Connection = con;
                recordsAffected = cmd.ExecuteNonQuery();
                if (recordsAffected == 0)
                {
                    throw new Exception("Couldn't insert record!!!");
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                //8.Closing the connection
                con.Close();
            }
            return recordsAffected;
        }
        public List<BookData> ShowList()
        {
            List<BookData> book = new List<BookData>();
            //2.Configure the command for SELECT
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            //3.Specify the command text for SELECT
            cmd.CommandText = "select * from BOOK order by BookID";
            //4.Attach connection
            cmd.Connection = con;
            //5.Open Connection
            con.Open();
            //6.Execute the command
            SqlDataReader reader = cmd.ExecuteReader();
            //7.Traverse the record and add them to the collection
            while (reader.Read())
            {
                BookData b = new BookData
                {
                    Id = (int)reader[0],
                    AuthorName = reader[1].ToString(),
                    BookName = reader[2].ToString(),
                    Category = reader[3].ToString(),
                    Quantity = (int)reader[4]
                };
                //8.Add it to the collection
                book.Add(b);
            }
            //9.Close the reader
            reader.Close();
            //10.Close the connection
            con.Close();
            //11.Return the records
            return book;
            
            
            
            /**/
        }
        public int AddUser(UserData user)
        {
            int recordsAffected = 0;
            try
            {
                //INSERT OPERATION
                //2.Configure the Sql Command for INSERT Statement
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                //3.Specify the command text for INSERT
                cmd.CommandText = "insert into [USER] values(@us,@pw,@name,@phn)";
                //4.Specify the values for the parameters
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@us", user.username);
                cmd.Parameters.AddWithValue("@pw", user.password);
                cmd.Parameters.AddWithValue("@name", user.name);
                cmd.Parameters.AddWithValue("@phn", user.phoneNumber);
                //5.Open the connection
                con.Open();
                //6. Attach the connecton with the command
                cmd.Connection = con;
                recordsAffected = cmd.ExecuteNonQuery();
                if(recordsAffected == 0)
                {
                    throw new Exception("Couldn't insert record!!!");
                }
            }
            catch(Exception ex)
            {
                throw;
            }
            finally
            {
                //8.Closing the connection
                con.Close();
            }
            return recordsAffected;
            
            
            //u.Add(new UserData { username = user.username, password = user.password, name = user.name, phoneNumber = user.phoneNumber });
        }
        public int returnBook(string name)
        {
            int recordsAffected = 0;
            try
            {
                //INSERT OPERATION
                //2.Configure the Sql Command for INSERT Statement
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                //3.Specify the command text for INSERT
                cmd.CommandText = "insert into [RETURN] values(@b)";
                //4.Specify the values for the parameters
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@b", name);
                //5.Open the connection
                con.Open();
                //6. Attach the connecton with the command
                cmd.Connection = con;
                recordsAffected = cmd.ExecuteNonQuery();
                if (recordsAffected == 0)
                {
                    throw new Exception("Couldn't insert record!!!");
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                //8.Closing the connection
                con.Close();
            }
            return recordsAffected;





            //ret.Add(new Return { BookName = name });
        }
        public int reserveBook(string name)
        {
            List<BookData> b = getBooks();
            int recordsAffected = 0;
            foreach (var book in b)
            {
                if (name.Equals(book.BookName))
                {
                    if (book.Quantity > 0)
                    {
                        try
                        {
                            //INSERT OPERATION
                            //2.Configure the Sql Command for INSERT Statement
                            SqlCommand cmd = new SqlCommand();
                            cmd.CommandType = CommandType.Text;
                            //3.Specify the command text for INSERT
                            cmd.CommandText = "insert into RESERVE values(@b)";
                            //4.Specify the values for the parameters
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@b", name);
                            //5.Open the connection
                            con.Open();
                            //6. Attach the connecton with the command
                            cmd.Connection = con;
                            recordsAffected = cmd.ExecuteNonQuery();
                            if (recordsAffected == 0)
                            {
                                throw new Exception("Couldn't insert record!!!");
                            }
                        }
                        catch (Exception ex)
                        {
                            throw;
                        }
                        finally
                        {
                            //8.Closing the connection
                            con.Close();
                        }
                    }
                    else
                        Console.WriteLine("Book is not available!!!");
                }
            }
            return recordsAffected;
        }

        public void reserveAdmin()
        {
            List<Reserve> res = getReserve();
            List<BookData> b = getBooks();
            if (res.Count == 0)
                Console.WriteLine("\n\nNothing in this list!!!!");
            else
            {
                Console.WriteLine("\n\tTitle\n");
                foreach (var r in res)
                {
                    Console.WriteLine("\t" + r.BookName);
                }
                Console.WriteLine("\nDo you wish to reserve these?(Y/N)");
                string YN = Console.ReadLine();
                switch (YN)
                {
                    case "Y":
                        int recordsAffected;
                        int i = 0;                        
                        
                        while (res.Count() > 0)
                        {
                            //for (i = 0; i < b.Count; i++)
                            //{
                                //if (res[0].BookName.Equals(b[i].BookName))
                                //{
                                    //2.Configure the Sql Command for INSERT Statement
                                    SqlCommand cmd = new SqlCommand();
                                    cmd.CommandType = CommandType.Text;
                                    //3.Specify the command text for INSERT
                                    cmd.CommandText = "UPDATE BOOK set Quantity=Quantity-1 where BookName=@b;DELETE from RESERVE where Name=@n";
                                    //4.Specify the values for the parameters
                                    cmd.Parameters.Clear();
                                    cmd.Parameters.AddWithValue("@b", res[0].BookName);
                                    cmd.Parameters.AddWithValue("@n", res[0].BookName);
                                    //5.Open the connection
                                    con.Open();
                                    //6. Attach the connecton with the command
                                    cmd.Connection = con;
                                    recordsAffected = cmd.ExecuteNonQuery();
                                    con.Close();
                                    res.RemoveAt(0);
                            /*//2.Configure the Sql Command for INSERT Statement
                             //SqlCommand cmd = new SqlCommand();
                             cmd.CommandType = CommandType.Text;
                             //3.Specify the command text for INSERT
                             cmd.CommandText = "DELETE from RESERVE where Name=@b";
                             //4.Specify the values for the parameters
                             cmd.Parameters.Clear();
                             cmd.Parameters.AddWithValue("@b", res[0].BookName);
                             //5.Open the connection
                             con.Open();
                             //6. Attach the connecton with the command
                             cmd.Connection = con;
                             recordsAffected = cmd.ExecuteNonQuery();
                             //b[i].Quantity -= 1;
                             res.RemoveAt(ind);

                             con.Close();*/

                            //}
                            //}
                        }
                        //Console.WriteLine(firstlist.Count());
                        Console.WriteLine("\nAll the orders have been completed!!!");
                        break;
                    case "N":
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

        public void returnAdmin()
        {
            List<Return> ret = getReturn();
            List<BookData> b = getBooks();
            if (ret.Count == 0)
                Console.WriteLine("\n\nNothing in this list!!!!");
            else
            {
                Console.WriteLine("\n\tTitle\n");
                foreach (var r in ret)
                {
                    Console.WriteLine("\t" + r.BookName);
                }
                Console.WriteLine("\nDo you wish to add these back?(Y/N)");
                string YN = Console.ReadLine();
                switch (YN)
                {
                    case "Y":
                        int flag = 0;
                        int ind = 0;
                        while (ret.Count > 0)
                        {
                            SqlCommand cmd = new SqlCommand();
                            cmd.CommandType = CommandType.Text;
                            //3.Specify the command text for INSERT
                            cmd.CommandText = "UPDATE BOOK set Quantity=Quantity+1 where BookName=@b;DELETE from [RETURN] where Name=@n";
                            //4.Specify the values for the parameters
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@b", ret[0].BookName);
                            cmd.Parameters.AddWithValue("@n", ret[0].BookName);
                            //5.Open the connection
                            con.Open();
                            //6. Attach the connecton with the command
                            cmd.Connection = con;
                            cmd.ExecuteNonQuery();
                            con.Close();
                            ret.RemoveAt(0);
                            flag = 1;

                            /*for (int i = 0; i < b.Count; i++)
                            {
                                if (ret[ind].BookName.Equals(b[i].BookName))
                                {
                                    b[i].Quantity += 1;
                                    ret.RemoveAt(ind);
                                    flag = 1;
                                    break;
                                }
                            }*/
                            if (flag == 0)
                            //ret.Remove(ret[ind]);
                            //else
                            {
                                Console.WriteLine("\n{0} doesn't belong to this library", ret[0].BookName);
                                ret.Remove(ret[0]);
                            }
                        }
                        Console.WriteLine("\nAll the books have been returned!!!");
                        break;
                    case "N":
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
