using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class PrimeFactor
    {
        public void Prime()
        {
            int n, leastPrimeNumber = 2, initialValue = 0;
            Console.WriteLine("Enter the value of N:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prime Factor of an Entered number is:");
            while (leastPrimeNumber <= n)
            {
                if (n % leastPrimeNumber == 0)
                {
                    initialValue = leastPrimeNumber;
                    Console.Write(initialValue + " ");
                    n = n / leastPrimeNumber;
                }
                else
                {
                    leastPrimeNumber++;
                }

            }
        }
    }
}
