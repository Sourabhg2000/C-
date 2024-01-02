using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a Year ");
                int year = int.Parse(Console.ReadLine());

                if (year % 4 == 0 || year % 400 == 0)
                {
                    Console.WriteLine($"This {year} year is Leap Year");
                }
                else
                {
                    Console.WriteLine($"This {year} is Not a Leap Year");
                }
            }
            catch (Exception)
            {

                throw;
            }
            Console.ReadKey();
        }
    }
}
