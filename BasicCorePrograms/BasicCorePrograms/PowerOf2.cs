using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class PowerOf2
    {
        public void PowerTable()
        {
            int baseValue = 2, n, powerValue = 1;
            Console.WriteLine("Enter the value of N:");
            n = Convert.ToInt32(Console.ReadLine());

            if (n >= 0 && n < 31)
            {
                Console.WriteLine("2^" + powerValue + "=" + baseValue);
                for (int i = 1; i < n; i++)
                {
                    powerValue++;
                    baseValue = baseValue * 2;
                    Console.WriteLine("2^" + powerValue + "=" + baseValue);
                }
            }
            else
            {
                if (n < 0)
                    Console.WriteLine("Invalid:Input should be a Positive Value");
                else
                    Console.WriteLine("Invalid:2^31 exceeds the integer value");
            }
        }
    }
}
