using System;
using System.IO;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks.Dataflow;

namespace project
{
    class Program
    {
        static void Main()
        {
     
      //   Killer killer = new Killer("Killer", 200, new byte[] { 1, 2, 3 }, 100, Type.Hero);
      //   killer.printValues();
      //   killer.Laser();

      // Bot bot1 = new Bot();
      // bot1.SetValues("Alex");
      // bot1.printValues();

      Book book1 = new Book();
      book1.SetValues("The Lord of the Rings", "J.R.R. Tolkien");
      book1.printValues();
      
        }

        public static void Multiply(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Result: " + result);

        }

        public static void Multiply(float a, float b)
        {
            float result = a * b;
            Console.WriteLine("Result float: " + result);

        }
      
 public static void Multiply(double a)
        {
            double result = a * 2;
            Console.WriteLine("Result double: " + result);

        }
       

      
    }
}
