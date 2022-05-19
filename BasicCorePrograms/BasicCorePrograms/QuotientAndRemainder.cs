using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class QuotientAndRemainder
    {
        public void Division()
        {
            int dividend, divisor;
            double quotient, remainder;
            Console.WriteLine("Enter the value of dividend:");
            dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of divisor:");
            divisor = Convert.ToInt32(Console.ReadLine());

            quotient = dividend / divisor;
            remainder = dividend % divisor;
            Console.WriteLine("Quotient is:" + quotient);
            Console.WriteLine("Remainder is:" + remainder);
        }
    }
}
