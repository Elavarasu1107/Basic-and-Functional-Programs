using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class VowelsOrConsonant
    {
        public void Alphabet()
        {
            Console.WriteLine("Enter an Alphabet:");
            string userInput = Console.ReadLine().ToLower();

            if (userInput.Length == 1)
            {
                if (userInput == "a" || userInput == "e" || userInput == "i" || userInput == "o" || userInput == "u")
                {
                    Console.WriteLine("Entered alphabet is a Vowel");
                }
                else
                {
                    Console.WriteLine("Entered alphabet is a Consonant");
                }
            }
            else
            {
                Console.WriteLine("Invalid:Enter a single character");
            }
        }
    }
}
