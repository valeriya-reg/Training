using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex.1 Write an expression that checks whether an integer is odd or even.

            //Method_1
            /*
            int a = 3;
            int b = 4;
            Console.WriteLine(a % 2);
            Console.WriteLine(b % 2);
            Console.ReadLine();
            */

            //Method_2
            Console.WriteLine("Enter x: ");
            int x = int.Parse(Console.ReadLine());

            int r = x % 2;
                if (r == 0) 
                    {
                        Console.WriteLine ("even");
                    }
                else
                    {
                        Console.WriteLine ("odd");
                    }
                Console.ReadLine();
        }
    }
}
