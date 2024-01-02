using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Department No: ");
                int did = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Designation Code: ");
                char dcode = char.Parse(Console.ReadLine());

                if (did == 10 && dcode == 'M') { Console.WriteLine($" Department No: {did}, Department Name Purchase , Designation Code {dcode} , Designation Manager "); }
                if (did == 20 && dcode == 'S') { Console.WriteLine($" Department No: {did}, Department Name Sales , Designation Code {dcode} , Designation Supervisor "); }
                if (did == 30 && dcode == 'A') { Console.WriteLine($" Department No: {did}, Department Name Production , Designation Code {dcode} , Designation Analyst "); }
                if (did == 40 && dcode == 's') { Console.WriteLine($" Department No: {did}, Department Name Marketing , Designation Code {dcode} , Designation Sales Person "); }
                if (did == 50 && dcode == 'a') { Console.WriteLine($" Department No: {did}, Department Name Accounts , Designation Code {dcode} , Designation Accountant "); }

            }
            catch (Exception)
            {

                throw;
            }
            Console.ReadKey();
        }
    }
}
