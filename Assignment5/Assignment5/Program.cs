using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=10;
            int b = 20;
            int c=0;

            Console.WriteLine("Numbers Before Swapping is : " + a +" "+ b);

            c = a;
            a = b;
            
            b = c;

            Console.WriteLine("Numbers After Swpping is : " + a +" "+ b);

            Console.ReadKey();

        }
    }
}
