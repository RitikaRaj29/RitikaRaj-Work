using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dog d = new Dog();
            Console.WriteLine("enter dog name");
            d.name = Console.ReadLine();
            Console.WriteLine("enter the age");
            d.age = int.Parse(Console.ReadLine());
            d.makeSound();

            Frog f = new Frog();
            Console.WriteLine("enter frog name");
            f.name = Console.ReadLine();
            Console.WriteLine("enter the age");
            f.age = int.Parse(Console.ReadLine());
            f.makeSound();

            Cat c = new Cat();
            Console.WriteLine("enter cat name");
            c.name = Console.ReadLine();
            Console.WriteLine("enter the age");
            c.age = int.Parse(Console.ReadLine());
            c.makeSound();

            Kitten k = new Kitten();
            Console.WriteLine("enter kitten name");
            k.name = Console.ReadLine();
            Console.WriteLine("enter the age");
            k.age = int.Parse(Console.ReadLine());
            k.makeSound();



            Tomcat t = new Tomcat();
            Console.WriteLine("enter tomcat name");
            t.name = Console.ReadLine();
            Console.WriteLine("enter the age");
            t.age = int.Parse(Console.ReadLine());
            t.makeSound();

            Animal[] ani = new Animal[5] { d, f, c, k, t };

            for (int i = 0; i < ani.Length; i++)
            {
                Console.WriteLine("{0}\t {1}{2}{3}{4} ", ani[i].name, ani[i].age);
            }
            Console.WriteLine();
        }
    }
    class Animal
    {
        public int age;
        public string name;
        public string gender;

        public virtual void makeSound()
        {

        }
    }
    class Dog : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("the dog barks");
        }

    }
    class Frog : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("the frogs croak");
        }
    }


    class Cat : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("the cat meows");
        }

    }
    class Kitten : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("the kitten meows");
        }



    }
    class Tomcat : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("the tomcat yowl");
        }

    }
}

