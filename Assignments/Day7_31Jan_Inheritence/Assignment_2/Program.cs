using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animals[] animals = new Animals[8];
            animals[0] = new Dog(26, "jerry", 'F');
            animals[1] = new Frog(26, "Ice", 'm');
            animals[2] = new Cat(26, "Tuti Fruti", 'F');
            animals[3] = new Kitten(26, "Red", 'M');
            animals[4] = new Tomcat(26, "Mewon", 'F');
            for(int i = 0; i < 5; i++)
            {
                animals[i].Sound();
            }

        }
        class Animals
        {
            public int age { get; set; }
           public string name { get; set; }
            public char gender { get; set; }

            public virtual void Sound()
            {
                Console.WriteLine("{0} makes sound",name);
               
            }
        }
        class Dog : Animals
        {
            public Dog(int _age,string _name,char gen)
            {
                this.age = _age;    
                this.name = _name;
                this.gender = gen;  

            }
            public override void Sound()
            {

              base.Sound();
              Console.WriteLine( "Bhao Bhao");
            }

        }
        class Frog : Animals
        {
            public override void Sound()
            {
                base.Sound();
                Console.WriteLine("Bhurr bhurrr");
            }
            public Frog(int _age, string _name, char gen)
            {
                this.age = _age;
                this.name = _name;
                this.gender = gen;

            }
        }
        class Cat : Animals
        {
            public Cat(int _age, string _name, char gen)
            {
                this.age = _age;
                this.name = _name;
                this.gender = gen;

            }
            public override void Sound()
            {
                base.Sound();
                Console.WriteLine("mewon mewon");
            }
        }
        class Kitten : Animals
        {
            public Kitten(int _age, string _name, char gen)
            {
                this.age = _age;
                this.name = _name;
                this.gender = gen;

            }
            public override void Sound()
            {
                base.Sound();
                Console.WriteLine("mee mee");
            }
        }
        class Tomcat : Animals
        {
            public Tomcat(int _age, string _name, char gen)
            {
                this.age = _age;
                this.name = _name;
                this.gender = gen;

            }
            public override void Sound()
            {
                base.Sound();
                Console.WriteLine("GRR GRR");
            }

        }
    }
}
