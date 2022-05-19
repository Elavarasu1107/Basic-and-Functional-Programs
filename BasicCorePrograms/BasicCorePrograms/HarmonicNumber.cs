using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class HarmonicNumber
    {
        public void Harmonic()
        {
            Decimal n, initialValue = 0;
            Console.WriteLine("Enter the value of N:");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                initialValue = initialValue + Decimal.Divide(1, i);
            }
            Console.WriteLine("Harmonic value of Entered Number is:" + Math.Round(initialValue, 3));

        }
    }
}
