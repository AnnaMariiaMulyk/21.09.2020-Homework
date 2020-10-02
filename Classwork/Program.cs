using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Classwork
{
    interface IRunable
    {
        float speedOfRun { get; set; }
        void Run();
    }
    interface ICrowable
    {
        float speedOfCrow { get; set; }
        void Crow();
    }
    interface IFlyable
    {
        float highOfFly { get; set; }
        void Fly();
    }
    interface ISwimmable
    {
        float swimmingDepth { get; set; }
        void Swim();
    }
    abstract class Creature
    {
        public abstract void Print();
    }
    class Animal:Creature
    {
        protected string name { get; set; }
        public Animal()
        {
            name = "noname";
        }
        public Animal(string name)
        {
            this.name = name;
        }
        public override void Print()
        {
            Console.WriteLine("Name: " + name);
        }
    }
    class Reptile : Animal, ICrowable
    {
        public float speedOfCrow
        {
            get
            {
                return speedOfCrow;
            }
            set
            {
                if (value > 0)
                    speedOfCrow = value;
                else
                    speedOfCrow = 0;
            }
        }
        public Reptile():base()
        {
            speedOfCrow = 0;
        }
        public Reptile(string name, float speed):base(name)
        {
            speedOfCrow = speed;
        }
        public void Crow()
        {
            Console.WriteLine("I am crowing. My speed is: " + speedOfCrow);
        }
        public override void Print()
        {
            Console.WriteLine("REPTILE");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Speed of crow: " + speedOfCrow);
        }
    }
    class Mammal:Animal, IRunable
    {
        protected string colorOfHair { get; set; }
        public float speedOfRun
        {
            get
            {
                return speedOfRun;
            }
            set
            {
                if (value > 0)
                    speedOfRun = value;
            }
        }

        public Mammal():base()
        {
            colorOfHair = "unknown";
            speedOfRun = 0;
        }
        public Mammal(string name, string color, float speed):base(name)
        {
            colorOfHair = color;
            speedOfRun = speed;
        }
        public void Run()
        {
            Console.WriteLine("I am runing. My speed is: " + speedOfRun);
        }
        public override void Print()
        {
            Console.WriteLine("MAMMAL");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Speed of run: " + speedOfRun);
            Console.WriteLine("Color of hair: " + colorOfHair);
        }
    }
    class Fish:Animal, ISwimmable
    {
        protected string livingEnviroment { get; set; }
        public float swimmingDepth
        {
            get
            {
                return swimmingDepth;
            }
            set
            {
                if (value > 0)
                    swimmingDepth = value;
                else
                    swimmingDepth = 0;
            }
        }

        public void Swim()
        {
            Console.WriteLine("I am swimming. My swimming depth is: " + swimmingDepth);
        }
        public override void Print()
        {
            Console.WriteLine("FISH");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Swimming depth: " + swimmingDepth);
            Console.WriteLine("Living enviroment: " + livingEnviroment);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
