using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class LargestNumber
    {
        public void LargestOf3()
        {
            int[] numbers = new int[3];
            Console.WriteLine("Enter 3 Numbers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            if (numbers[0] > numbers[1] || numbers[0] > numbers[2])
            {
                Console.WriteLine(numbers[0] + " " + "is the largest number");
            }
            else if (numbers[0] > numbers[1] || numbers[1] > numbers[2])
            {
                Console.WriteLine(numbers[1] + " " + "is the largest number");
            }
            else
            {
                Console.WriteLine(numbers[2] + " " + "is the largest number");
            }
        }
    }
}
