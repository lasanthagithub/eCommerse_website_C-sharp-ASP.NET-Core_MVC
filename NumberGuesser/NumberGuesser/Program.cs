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

            //guessNumber = GetGuess();


            //while (ourNumber != guessNumber)
            //{
            //    if (ourNumber == guessNumber)
            //    {
            //        Console.WriteLine("That is it: Well done");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry. Not even close");
            //        guessNumber = GetGuess();

            //    }
            //}

            for (int n = 10; n > 0; n--)// n-- equal to n = n -1
            {
                guessNumber = GetGuess();
                if (ourNumber == guessNumber)
                {
                    Console.WriteLine("That is it: Well done");
                    break;
                }
                else if (ourNumber < guessNumber)
                {
                    Console.WriteLine("Sorry. you were too high, you have {0} guesses left", n -1);
                }
                else
                {
                    Console.WriteLine("Sorry. you were too low, you have {0} guesses left", n - 1);
                }
            }

            Console.WriteLine("Enter any key to trminate");

            Console.ReadLine();

        }
    }
}
