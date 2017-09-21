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
            
            int guessNumber = 0;
            //int ourNumber = 10;
            //guessNumber = GetGuess();

            // Using While loop
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


            // Using for loop
            //for (int n = 10; n > 0; n--)// n-- equal to n = n -1
            //{
            //    guessNumber = GetGuess();
            //    if (ourNumber == guessNumber)
            //    {
            //        Console.WriteLine("That is it: Well done");
            //        break;
            //    }
            //    else if (ourNumber < guessNumber)
            //    {
            //        Console.WriteLine("Sorry. you were too high, you have {0} guesses left", n -1);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry. you were too low, you have {0} guesses left", n - 1);
            //    }
            //}

            const int ourNumber = 10;
            // Using switch
            for (int n = 10; n > 0; n--)// n-- equal to n = n -1
            {
                guessNumber = GetGuess();
                switch (guessNumber)
                {
                    case (ourNumber):
                        Console.WriteLine("That is it: Well done");
                        n = 0;
                        break;

                    case (1):
                        {
                            Console.WriteLine("Thats too low");
                            break;
                        }

                    case (100):
                        {
                            Console.WriteLine("Thats too high");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Sorry, that was wrong");
                            if (ourNumber < guessNumber)
                            {
                                Console.WriteLine("Sorry. you were too high, you have {0} guesses left", n - 1);
                            }
                            else
                            {
                                Console.WriteLine("Sorry. you were too low, you have {0} guesses left", n - 1);
                            }                            
                            break;
                        }
                }
            }


            Console.WriteLine("Enter any key to trminate");

            Console.ReadLine();

        }
    }
}
