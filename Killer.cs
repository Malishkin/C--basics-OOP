using System;

namespace project
{

    enum Type
    {
        Enemy, Hero, Traitor
    }
    class Killer : Robot
    {
       
       public Type type;

      public Killer() 
        {
            
        }

        public Killer(string name, int weight, byte[] coordinates, int health, Type type) : base(name, weight, coordinates)
        {
            this.Health = health;
            this.type = type;
           
        }

        public override void printValues()
        {
           Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Weight: {this.Weight}");
            Console.WriteLine($"Health: {this.Health}");

            if (this.type == Type.Enemy)
            {
                Console.WriteLine("Type: Enemy");
            }
            else if (this.type == Type.Hero)
            {
                Console.WriteLine("Type: Hero");
            }
            else if (this.type == Type.Traitor)
            {
                Console.WriteLine("Type: Traitor");
            }   
        }

        public Killer(string name) : base(name)
        {
            
        }

        public int Health { get; set; }
        public void Laser()
        {
            Console.WriteLine("Laser shooting");
            this.surnaaame = "Killer Ivanov";

        }
    }
}