using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter M1-Marks");
                int m1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter M2-Marks");
                int m2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter M3-Marks");
                int m3 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Graphics-Marks");
                int Gr = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter BXE-Marks");
                int bxe = int.Parse(Console.ReadLine());

                int sum = m1 + m2 + m3 + Gr + bxe;
                int avg = (m1 + m2 + m3 + Gr + bxe) / 5;

                Console.WriteLine($"The Sum of Five Subjects is {sum}");
                Console.WriteLine($"The Average of Five Subject is {avg}");
            }
            catch (Exception err)
            {

                throw err;
            }
            Console.ReadKey();


        }
    }
}
