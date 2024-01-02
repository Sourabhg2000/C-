using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a Number");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter a Number");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter a Number");
                int c = int.Parse(Console.ReadLine());
                int max;

                if (a > b && a > c)
                {
                    max = a;
                }
                else if (b > c && b > a)
                {
                    max = b;
                }
                else
                {
                    max = c;
                }

                Console.WriteLine($"The Maximum Number Between {a}, {b}, {c} is " + max);
            }
            catch (Exception)
            {

                throw;
            }
            Console.ReadKey();
        }
    }
}
