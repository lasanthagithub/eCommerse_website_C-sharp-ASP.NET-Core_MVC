using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Dog
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Defining 1D arrarys: Arrays are zero indexing
            int[] intArray = new int[5];
            string[] stringArray = new string[5];

            int[] populatedIntArray = new int[] {0, 1, 2, 3, 4, 5, 6 };
            string[] populatedStringArray = new string[] {"One", "two", "three" };

            // Assigning elements to array
            intArray[0] = 5;
            intArray[2] = 15;

            // Accessing array values
            int firstValue = intArray[0];

            // 2D arrays
            int[,] mulyiInt = new int[2, 3];
            int[,] multiIntWithContent = { {2, 3, 4 }, {5, 6, 7} };

            Console.WriteLine(multiIntWithContent[0, 0] + multiIntWithContent[0, 2]);
            Console.WriteLine("Row 0, column 0: "+ multiIntWithContent[0, 0] + "; row 0, column 2: " + multiIntWithContent[0, 2]);

            // User define arrays
            Dog[] dogArray = new Dog[5];
            dogArray[0] = new Dog() { Name = "Rover" };

            // List collection
            List < string > strings = new List<string>();
            strings.Add("String 1");
            strings.Add("String 2");
            strings.Add("String 3");

            // Accesing data
            string getValue = strings[0];

            // Insert an element to given postion
            strings.Insert(1, "inserted new");
            // Remove an element
            strings.Remove("String 2"); // search adn remove
            strings.RemoveAt(2); // remove at index

            // List sorting
            strings.Sort();


            // Dictionary collection


            Console.ReadLine();
        }
    }
}
