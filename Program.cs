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
      //    Bot bot = new Bot("Bot", 100, new byte[] { 1, 2, 3 });
      //      bot.printValues();
        Killer killer = new Killer("Killer", 200, new byte[] { 1, 2, 3 }, 100, Type.Hero);
        killer.printValues();
        killer.Laser();

      Bot bot1 = new Bot();
      bot1.SetValues("Alex");
      bot1.printValues();
      // bot1.Weight=100;
      //   Console.WriteLine(bot1.Weight);
      //    Multiply(1.5f, 6f);
      // Multiply(25d);
            
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
