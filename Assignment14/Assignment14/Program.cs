using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14
{
    internal class Program
    {
        public void getDate(String Date)
        {
            Console.WriteLine("The Date is : " + Date);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Date in format dd/mm/yy : ");
            String date = Console.ReadLine();

            Program p =new Program();
            p.getDate(date);
            Console.ReadKey();
        }
    }
}
