using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int num =int.Parse(Console.ReadLine());

            if( num < 0)
            {
                int abs_num = Math.Abs(num);
                Console.WriteLine($"The Absolute Number of {num} is : "+abs_num);
            }
            else
            {
                Console.WriteLine($"The Absolute Number of {num} is : "+num); 
            }
            Console.ReadKey();
        }
    }
}
