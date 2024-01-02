using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Sales Amount in Rs. ");
                int sal = int.Parse(Console.ReadLine());
                double com = 0;

                if (sal > 5000 && sal > 7500)
                {
                    com = 0.03 * sal;
                }
                else if (sal > 7501 && sal < 10500)
                {
                    com = 0.08 * sal;
                }
                else if (sal > 10501 && sal < 15000)
                {
                    com = 0.11 * sal;
                }
                else
                {
                    com = 0.15 * sal;
                }

                Console.WriteLine($"Commision on Sales Amount {sal} is : " + com);
            }
            catch (Exception)
            {

                throw;
            }
            Console.ReadKey();
        }
    }
}
