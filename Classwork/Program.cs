using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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
        float HighOfFly { get; set; }
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
        protected string LivingEnviroment { get; set; }
        public Fish():base()
        {
            LivingEnviroment = "unknown";
        }
        public Fish(string name, string enviroment):base(name)
        {
            LivingEnviroment = enviroment;
        }
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
            Console.WriteLine("Living enviroment: " + LivingEnviroment);
        }
    }
    class Bird : Animal, IFlyable
    {
        public float HighOfFly
        {
            get
            {
                return HighOfFly;
            }
            set
            {
                if (value > 0)
                    HighOfFly = value;
                else
                    HighOfFly = 0;
            }
        }
        protected string ColorOfFeathers { get; set; }
        public Bird():base()
        {
            HighOfFly = 0;
            ColorOfFeathers = "unknown";
        }
        public Bird(string name, float heigh, string color):base(name)
        {
            HighOfFly = heigh;
            ColorOfFeathers = color;
        }
        public void Fly()
        {
            Console.WriteLine("I`m flying with this height: " + HighOfFly);
        }
        public override void Print()
        {
            Console.WriteLine("BIRD");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Height if fly: " + HighOfFly);
            Console.WriteLine("Color of feathers: " + ColorOfFeathers);
        }
    }
    class Bear:Mammal
    {
        private float Weight 
        { 
            get
            {
                return Weight;
            }
            set
            {
                if (value > 0)
                    Weight = value;
                else
                    Weight = 0;
            }
        }
        public Bear():base()
        {
            Weight = 0;
        }
        public Bear(string name, string color, float speed, float weight):base(name, color, speed)
        {
            this.Weight = weight;
        }
        public override void Print()
        {
            Console.WriteLine("BEAR");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Speed of run: " + speedOfRun);
            Console.WriteLine("Color of hair: " + colorOfHair);
            Console.WriteLine("Weight: " + Weight);
        }
        public void Hunt()
        {
            Random rand = new Random();
            int temp = rand.Next(1, 3);
            switch (temp)
            {
                case 1:
                    {
                        Console.WriteLine("Catching fish in river");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Looking for berries, mushrooms");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Cathing small animal");
                        break;
                    }
                default:
                    break;
            }
        }
    }
    class Frog:Reptile
    {
        private string CountryOfSpread { get; set; }
        public Frog():base()
        {
            CountryOfSpread = "unknown";
        }
        public Frog(string name, float speed, string country):base(name, speed)
        {
            CountryOfSpread = country;
        }
        public void JumpAndTalk()
        {
            Console.WriteLine("I`m jumping. KWA KWA KWA");
        }
        public override void Print()
        {
            Console.WriteLine("FROG");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Speed of crow" + speedOfCrow);
            Console.WriteLine("Cpuntry of spread: " + CountryOfSpread);
        }

    }
    class Dolphin : Mammal, ISwimmable
    {
        private float Length
        {
            get
            {
                return Length;
            }
            set
            {
                if (value > 0)
                    Length = value;
                else
                    Length = 0;
            }
        }
        public Dolphin():base()
        {
            Length = 0;
        }
        public Dolphin(string name, string color, float speed, float length):base(name, color, speed)
        {
            Length = length;
        }
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
            Console.WriteLine("DOLPHIN");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Swimming depth: " + swimmingDepth);
            Console.WriteLine("Length: " + Length);
        }
    }
    class Carp:Fish
    {
        private float Weight
        {
            get
            {
                return Weight;
            }
            set
            {
                if (value > 0)
                    Weight = value;
                else
                    Weight = 0;
            }
        }
        public Carp():base()
        {
            Weight = 0;
        }
        public Carp(string name, string enviroment, float weight):base(name, enviroment)
        {
            Weight = weight;
        }
        public override void Print()
        {
            Console.WriteLine("CARP");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Living enviroment: " + LivingEnviroment);
            Console.WriteLine("Weight: " + Weight);
        }
        public void LayEggs()
        {
            Console.WriteLine("I`m laying eggs");
        }
    }
    class Eagle:Bird
    {
        private int countOfKilledMouses;
        public Eagle():base()
        {
            countOfKilledMouses = 0;
        }
        public Eagle(string name,float heigh, string color):base(name, heigh, color)
        {
            countOfKilledMouses = 0;
        }
        public override void Print()
        {
            Console.WriteLine("EAGLE");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Height if fly: " + HighOfFly);
            Console.WriteLine("Color of feathers: " + ColorOfFeathers);
            Console.WriteLine("Count of killed mouses: " + countOfKilledMouses);
        }
        public void EatMouse()
        {
            countOfKilledMouses++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
