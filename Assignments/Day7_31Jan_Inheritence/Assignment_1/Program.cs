using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the cow name");
            string cname;
            cname=Console.ReadLine();
            cow c=new cow();
            c.SetName(cname);
            c.GetName();
            c.Eat();

            Console.WriteLine("Enter the Lion name");
            string lname;
            lname = Console.ReadLine();
            Lion l = new Lion();
            l.SetName(lname);
            l.GetName();
            l.Eat();



        }
    }
    abstract class Animal
    {
        public string Name { get; set; }

        public abstract void Eat();

        public void SetName(string name)
        {
            Name = name;
        }
        public void GetName()
        {
            Console.WriteLine("Animal name is {0}",Name);    
        }

    }
    class Lion : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("The lion is eating flesh.");
        }

    }
    class cow : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("The cow is eating grass.");
        }
    }

}
