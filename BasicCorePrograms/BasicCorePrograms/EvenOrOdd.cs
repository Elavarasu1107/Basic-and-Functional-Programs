using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class EvenOrOdd
    {
        public void Numbers()
        {
            Console.WriteLine("Enter the value:");
            int userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput % 2 == 0)
            {
                Console.WriteLine("Entered Number is an Even Number");
            }
            else
            {
                Console.WriteLine("Entered Number is an Odd Number");
            }
        }
    }
}
