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
                        CoinFlip getMethod = new CoinFlip();
                        getMethod.Toss();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("LeapYear");
                        LeapYear getMethod = new LeapYear();
                        getMethod.Year();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Power Of 2");
                        PowerOf2 getMethod = new PowerOf2();
                        getMethod.PowerTable();
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Harmonic Number");
                        HarmonicNumber getMethod = new HarmonicNumber();
                        getMethod.Harmonic();
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Prime Factorization");
                        PrimeFactor getMethod = new PrimeFactor();
                        getMethod.Prime();
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Quotient And Remainder");
                        QuotientAndRemainder getMethod = new QuotientAndRemainder();
                        getMethod.Division();
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Swaping Two Numbers");
                        SwappingNumbers getMethod = new SwappingNumbers();
                        getMethod.SwapTwoNumbers();
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("Even Or Odd");
                        EvenOrOdd getMethod = new EvenOrOdd();
                        getMethod.Numbers();
                        break;
                    }
               default:
                    {
                        Console.WriteLine("Enter a Number between(1-8)");
                        break;
                    }
            }
        }
    }
}
