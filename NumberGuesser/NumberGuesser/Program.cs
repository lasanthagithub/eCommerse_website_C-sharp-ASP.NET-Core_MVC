using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class Program
    {
        static int GetGuess()
        {
            Console.WriteLine("Please enter a number ");
            string answer = Console.ReadLine();

            // convert string to int
            int guessNumber = 0;
            Int32.TryParse(answer, out guessNumber);
            return guessNumber;
        }

        static void Main(string[] args)
        {
            int ourNumber = 10;
            int guessNumber = 0;

            guessNumber = GetGuess();


            while (ourNumber != guessNumber)
            {
                if (ourNumber == guessNumber)
                {
                    Console.WriteLine("That is it: Well done");
                }
                else
                {
                    Console.WriteLine("Sorry. Not even close");

                }
            }


            Console.WriteLine("Enter any key to trminate");

            Console.ReadLine();

        }
    }
}
