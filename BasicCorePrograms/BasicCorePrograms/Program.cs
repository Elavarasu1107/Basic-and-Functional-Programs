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
                        Console.WriteLine("CoinFlip");
                        CoinFlip getClass = new CoinFlip();
                        getClass.Toss();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("LeapYear");
                        LeapYear getClass = new LeapYear();
                        getClass.Year();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Power Of 2");
                        PowerOf2 getClass = new PowerOf2();
                        getClass.PowerTable();
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Harmonic Number");
                        HarmonicNumber getClass = new HarmonicNumber();
                        getClass.Harmonic();
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Prime Factorization");
                        PrimeFactor getClass = new PrimeFactor();
                        getClass.Prime();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter a Number between(1-5)");
                        break;
                    }
            }
        }
    }
}
