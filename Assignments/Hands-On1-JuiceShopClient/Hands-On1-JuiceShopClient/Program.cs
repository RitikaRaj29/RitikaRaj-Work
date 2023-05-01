using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hands_On1_JuiceShopClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            juice[] juices = new juice[1];

            JuiceShopDal userBO = new JuiceShopDal();


            juices = userBO.add(1001, "APPLE", 50, juices);
            juices = userBO.add(1002, "Mango", 20, juices);
            juices = userBO.add(1003, "Grape", 30, juices);
            juices = userBO.add(1004, "Banana", 20, juices);
            juices = userBO.add(1005, "orange", 70, juices);

            userBO.Display(juices);

        }
    }
    class JuiceShopBo
    {
        //logic to add
        public juicePurchsed[] add1(int quantity, int amount, juicePurchsed[] userss)
        {
            int size = userss.Length;
            juicePurchsed user = new juicePurchsed { amount = amount, quantity = quantity };
            userss[size - 1] = user;

            juicePurchsed[] uu = new juicePurchsed[size + 1];

            for (int i = 0; i < userss.Length; i++)
            {
                uu[i] = userss[i];
            }
            return uu;



        }

        public void DisplayFun(juicePurchsed[] users)

        {
            Console.WriteLine("Available Juice Flavour");

            for (int i = 0; i < users.Length - 1; i++)
            {
                Console.WriteLine("{0}\t{1}", users[i].quantity, users[i].amount);
            }
        }


    }

    class JuiceShopDal
    {
        public juice[] add(int juice_id, string juice_flavour, int price, juice[] users)
        {

            int initalSize = users.Length;
            juice user = new juice { juice_id = juice_id, juice_flavour = juice_flavour, price = price };
            users[initalSize - 1] = user;

            juice[] updatedUsers = new juice[initalSize + 1];
            for (int i = 0; i < users.Length; i++)
            {
                updatedUsers[i] = users[i];
            }
            return updatedUsers;

        }


        public void Display(juice[] users)
        {

            bool k = false;

            do
            {

                Console.WriteLine("=========================");
                Console.WriteLine("Available Juice Flavour");
                Console.WriteLine("=========================");
                Console.WriteLine("{0}\t{1}\t{2}", "id", "flavour", "price");
                for (int i = 0; i < users.Length - 1; i++)
                {
                    Console.WriteLine("{0}\t{1}\t{2}", users[i].juice_id, users[i].juice_flavour, users[i].price);
                }




                Console.WriteLine("Enter juice flavour id");

                int id_check = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < users.Length - 1; i++)
                {


                    if (id_check == users[i].juice_id)
                    {
                        Console.WriteLine("Enter Quantity");
                        int Quantity = Convert.ToInt32(Console.ReadLine());
                        int amount = Quantity * users[i].price;
                        Console.WriteLine("Total purchase : {0}\t", amount);

                        //saving to array

                        juicePurchsed[] purchasedData = new juicePurchsed[1];
                        JuiceShopBo pd = new JuiceShopBo();
                        purchasedData = pd.add1(Quantity, amount, purchasedData);





                        Console.WriteLine("Y for save and display bill , Any key for Not");
                        string query = Console.ReadLine();

                        if (query == "Y" || query == "y")
                        {

                            Console.WriteLine("Here is your saved bill");

                            pd.DisplayFun(purchasedData);


                        }

                        Console.WriteLine("Want to add more Y for yes N for no");
                        string query1 = Console.ReadLine();

                        if (query1 == "Y" || query1 == "y")
                        {
                            k = true;
                        }
                        else
                        {
                            k = false;
                        }




                    }



                }
            } while (k);

        }







    }


    class juice
    {
        public int juice_id { get; set; }
        public string juice_flavour { get; set; }
        public int price { get; set; }

    }

    class juicePurchsed
    {

        public int juice_id { get; set; }
        public int quantity { get; set; }
        public int amount { get; set; }

    }
}

