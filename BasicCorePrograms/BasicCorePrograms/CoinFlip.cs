using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class CoinFlip
    {
        public void Toss()
        {
            int input;
            float headsPercent, tailsPercent, noOfHeads = 0, noOfTails = 0;

            Console.WriteLine("Enter a number of times coin to be Tossed:");
            input = Convert.ToInt32(Console.ReadLine());
            Random value = new Random();
            for (int i = 0; i < input; i++)
            {
                int randomCheck = value.Next(2);
                if (randomCheck == 0)
                {
                    noOfHeads++;
                }
                else
                {
                    noOfTails++;
                }
            }
            Console.WriteLine("No of times heads is fliped:" + noOfHeads);
            Console.WriteLine("No of times tails is fliped:" + noOfTails);
            headsPercent = (noOfHeads * 100) / input;
            tailsPercent = (noOfTails * 100) / input;
            Console.WriteLine("Heads Percentage:" + Math.Round(headsPercent, 3) + "%");
            Console.WriteLine("Tails Percentage:" + Math.Round(tailsPercent, 3) + "%");
            Console.WriteLine();
        }
    }
}
