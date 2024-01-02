using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Number 1");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Number 2");
                int x1 = int.Parse(Console.ReadLine());

                int sum = x + x1;
                Console.WriteLine("The Sum of Two Number is = " + sum);
            }
            catch (Exception)
            {

                throw;
            }

            Console.ReadKey();
        }
    }
}
