using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a Number ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter a Number ");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Choose an Operation " +
                    "1.Add" +
                    "2. Subtract" + "3. Multiplication" + "4. Divide" + "5 . Module"
                    );
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine($"The sum of {num1} , {num2} is" + num1 + num2);
                        break;

                    case 2:
                        Console.WriteLine($"The Difference of {num1} , {num2} is" + (num1 - num2));
                        break;

                    case 3:
                        Console.WriteLine($"The Multiplication  of {num1} , {num2} is" + num1 * num2);
                        break;

                    case 4:
                        Console.WriteLine($"The Divide of {num1} , {num2} is" + num1 / num2);
                        break;

                    case 5:
                        Console.WriteLine($"The sum of {num1} , {num2} is" + num1 % num2);
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
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
