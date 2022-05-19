using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class SwappingNumbers
    {
        public void SwapTwoNumbers()
        {
            int firstValue, secondValue, temporary;
            Console.Write("Enter First Number:"); firstValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number:"); secondValue = Convert.ToInt32(Console.ReadLine());

            temporary = firstValue;
            firstValue = secondValue;
            secondValue = temporary;
            Console.WriteLine();
            Console.WriteLine("Numbers after Swapping");
            Console.WriteLine();
            Console.WriteLine("First Number is:" + firstValue);
            Console.WriteLine("Second Number is:" + secondValue);
        }
    }
}
