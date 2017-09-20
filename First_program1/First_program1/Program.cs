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


            Console.ReadLine();

        }
    }
}

