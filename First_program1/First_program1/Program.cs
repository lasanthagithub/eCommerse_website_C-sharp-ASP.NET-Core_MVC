using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_program1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assignning variables
            string myF_Name = "Lasantha";
            string myL_Name;
            myL_Name = "Rathnayake";
            bool is_true = false;

            Console.WriteLine("Hello guys, I'm");
            Console.Write(myF_Name );
            Console.WriteLine(" " + myL_Name);

            int myNumber = 1;
            int myOtherNumber = 5;
            int answer = myNumber + myOtherNumber;
            Console.WriteLine(answer);

            // Convert numeric to string
            string string_Answer = answer.ToString();
            Console.WriteLine(string_Answer);

            string string_Answer1 = string_Answer;
            string_Answer1 = string_Answer;
            string string_Answer2 = string_Answer;
            // Convert numerical strigngs to number
            Convert.ToInt32(string_Answer1);
            Console.WriteLine(string_Answer1);

            Int32.Parse(string_Answer1);
            Console.WriteLine(string_Answer1);

            Int32.TryParse(string_Answer2, out int answer3);
            Console.WriteLine(answer3);

            // Read fro the console
            Console.WriteLine();

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            Console.WriteLine("Enter a number");
            string sNum1 = Console.ReadLine();
            Console.WriteLine("Enter a another number");
            string sNum2 = Console.ReadLine();

            Int32.TryParse(sNum1, out num1);
            Int32.TryParse(sNum2, out num2);

            answer = num1 + num2;

            Console.WriteLine("The answer is " + answer);
            Console.ReadLine(); // This Readline to kepp the Console without closing

        }
    }
}

