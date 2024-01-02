using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12
{
    using System;

    class Program
    {
        static int DaysInMonth(int month, int year)
        {
            int[] daysInMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            // Adjust for leap years
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                daysInMonth[2] = 29;
            }

            return daysInMonth[month];
        }

        static string MonthName(int month)
        {
            string[] monthNames = { "", "January", "February", "March", "April", "May", "June",
                                "July", "August", "September", "October", "November", "December" };

            return monthNames[month];
        }

        static void Main()
        {
            Console.Write("Enter date in dd/mm/yy format: ");
            string dateStr = Console.ReadLine();

            // Extract day, month, and year from the input string
            string[] dateParts = dateStr.Split('/');
            int day = int.Parse(dateParts[0]);
            int month = int.Parse(dateParts[1]);
            int year = int.Parse(dateParts[2]);

            // Check if the input month is valid
            if (month >= 1 && month <= 12)
            {
                // Get the number of days in the month
                int totalDays = DaysInMonth(month, year);

                // Get the name of the month
                string monthNameStr = MonthName(month);

                // Print the result
                Console.WriteLine($"Total number of days in {monthNameStr} {year}: {totalDays}");
            }
            else
            {
                Console.WriteLine("Invalid month. Please enter a month between 1 and 12.");
            }
            Console.ReadKey();
        }
        
    }

}
