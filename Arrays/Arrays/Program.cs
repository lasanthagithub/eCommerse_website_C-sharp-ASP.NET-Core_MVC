using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Legs { get; set; }
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

            List<Dog> dogs = new List<Dog>();
            Dog dog = new Dog();
            dog.Name = "Rover";
            dog.Legs = 4;

            // or
            Dog dog1 = new Dog() { Name = "Rover", Legs = 4};

            // or
            List<Dog> dogs1 = new List<Dog>() {
                new Dog() {Id = 1, Name = "Rover", Legs = 4 },
                new Dog() {Id = 2, Name = "Bantar", Legs = 4 }
            };

            // Search in a list (Linq queary)
            List<Dog> nameResults = (from d in dogs
                                 where d.Name == "Rover"
                                 select d).ToList(); // gives out a list
            
            Dog foundDog = (from d in dogs
                                 where d.Id == 1
                                 select d).FirstOrDefault(); // Gives out a single value

            var varResults1 = from d in dogs
                               where d.Id == 1
                               select d; // Gives out a single value. var will figure out the type

            // list Lambda method. 
            List<Dog> nameResults2;
            nameResults2 = dogs.Where(d => d.Name == "Bantar").ToList();// Identical to nameResults codes above

            Dog foundDog1;
            foundDog1 = dogs1.FirstOrDefault(d => d.Id == 1); // Identical to foundDog codes above


            // Dictionary collection
            Dictionary<string, string> names = new Dictionary<string, string>();
            names.Add("James", "Bond");
            names.Add("Money", "Penny");

            Console.WriteLine(names["Money"]);
            names.Remove("Money");




            Console.ReadLine();
        }
    }
}
