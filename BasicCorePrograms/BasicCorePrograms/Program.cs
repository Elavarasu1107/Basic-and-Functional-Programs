using System;

namespace BasicCorePrograms
{
    internal class Programs
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter a Number:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    {
                        CoinFlip getClass = new CoinFlip();
                        getClass.Toss();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("LeapYear");
                        LeapYear getClass=new LeapYear();
                        getClass.Year();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter a Number between(1-2");
                        break;
                    }
            }
        }
    }
}
