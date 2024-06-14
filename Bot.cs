using System;

namespace project
{
    class Bot : Robot
    {
       
       public override void printValues()
        {
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Weight: {this.Weight}");
            Console.WriteLine($"Coordinates: {this.Coordinates[0]} {this.Coordinates[1]} {this.Coordinates[2]}");
           
        }

      public Bot() 
        {
            
        }

        public Bot(string name, int weight, byte[] coordinates) : base(name, weight, coordinates)
        {
          
           
        }
       

      
       
    }
}