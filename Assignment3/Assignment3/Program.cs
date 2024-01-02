using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a Charachter");
                char c = char.Parse(Console.ReadLine());

                Console.WriteLine((int)c);
            }
            catch (Exception)
            {

                throw;
            }
            Console.ReadKey();
        }
    }
}
