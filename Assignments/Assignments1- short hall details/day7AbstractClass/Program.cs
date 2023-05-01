using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cow c = new Cow();
            Console.WriteLine("enter cow name ");
            c.name = Console.ReadLine();
            c.GetName();
            c.Eat();


            Lion l = new Lion();
            Console.WriteLine("enter lion name");
            l.name = Console.ReadLine();
            l.GetName();
            l.Eat();
        }
    }
    abstract class Animal
    {
        public string name;
        public string n;
        public abstract void SetName();
        public abstract string GetName();


    }
    class Lion : Animal
    {
        public override void SetName()
        {
            name = n;

        }
        public override string GetName()
        {
            return name;

        }
        public void Eat()
        {
            Console.WriteLine("the " + name + " is eating flesh ");
        }
    }
    class Cow : Animal
    {
        public override void SetName()
        {
            name = n;
        }
        public override string GetName()
        {
            return name;
        }
        public void Eat()
        {
            Console.WriteLine("the " + name + " is eating grass ");
        }
    }
}
    

    

