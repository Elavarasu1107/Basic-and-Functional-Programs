using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class LeapYear
    {
        public void Year()
        {
            Console.WriteLine("Enter a Year:");
            int year = Convert.ToInt32(Console.ReadLine());
            int maxDigit = year.ToString().Length;

            if (maxDigit == 4)
            {
                if (year % 400 == 0 || (year % 100 != 0 && year % 4 == 0))
                {
                    Console.WriteLine("Entered year" + " " + year + " " + "is LeapYear");
                }
                else
                {
                    Console.WriteLine("Entered year" + " " + year + " " + "is not a LeapYear");
                }
            }
            else
            {
                Console.WriteLine("Invalid:Enter a 4-digit Number");
            }
        }
    }
}
