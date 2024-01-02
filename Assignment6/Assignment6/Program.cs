using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double basic_salary = 42500.25;
            double HRA = 0.20*(basic_salary);
            double DA = 0.40 * (basic_salary);
            double PF =0.10 *(basic_salary);

            double Gross_salary = (basic_salary + HRA + DA); 
            double Net_salary = Gross_salary - PF;

            Console.WriteLine("Net Salary of Employee is = " +  Net_salary);
            Console.WriteLine("Gross Salary of Employee is = " + Gross_salary);

            Console.ReadKey();
        }
    }
}
