using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetClassification
{
    enum PetType {dog, duck}
    
    // Class and struct method 1
    class PetClass
    {
        public int Legs;
        public string Type;
        public string Name;
        public bool HasFur;
    }

    struct PetStruct
    {
        public int Legs;
        public string Type;
        public string Name;
        public bool HasFur;
    }


    // Class and struct method 2 using enumerate vlues
    class PetClass1
    {
        public int Legs;
        public PetType Type; // Note: new variable type
        public string Name;
        public bool HasFur;
    }

    struct PetStruct1
    {
        public int Legs;
        public PetType Type; // Note: new variable type
        public string Name;
        public bool HasFur;
    }

    class Program
    {
        // Defining MultipleLegs method
        static void MultipleLegs(PetStruct1 petStruct, PetClass1 petClass)
        {
            petStruct.Legs = petStruct.Legs *2;
            petClass.Legs = petClass.Legs * 2;

            Console.WriteLine("Internal method: A " + petStruct.Type + " has " + petStruct.Legs);
            Console.WriteLine("Internal method: A " + petClass.Type + " has " + petClass.Legs);

        }

        static void Main(string[] args)
        {
            // Using structure - example
            PetStruct dog;
            dog.Type = "Dog";
            dog.Legs = 4;
            dog.HasFur = true;
            Console.WriteLine("A " + dog.Type + " has " + dog.Legs + " legs");

            // Using Class - example
            PetClass duck = new PetClass();
            duck.Type = "Duck";
            duck.Legs = 2;
            duck.HasFur = false;
            Console.WriteLine("A " + duck.Type + " has " + duck.Legs + " legs");

            // Using structure using enumerate  - example
            PetStruct1 dog1 = new PetStruct1();
            dog1.Type = PetType.dog;
            dog1.Legs = 4;
            dog1.HasFur = true;
            Console.WriteLine("A " + dog1.Type + " has " + dog1.Legs + " legs");

            // Using Class using enumerate  - example
            PetClass1 duck1 = new PetClass1();
            duck1.Type = PetType.duck;
            duck1.Legs = 2;
            duck1.HasFur = false;
            Console.WriteLine("A " + duck1.Type + " has " + duck1.Legs + " legs");

            // Calling the method
            MultipleLegs(dog1, duck1);

            // Copy and assign previously used objects to new variables
            PetStruct1 copiedDog = dog1;
            PetClass1 copiedDuck = duck1;

            Console.WriteLine("A " + copiedDog.Type + " has " + copiedDog.Legs + " legs");
            Console.WriteLine("A " + copiedDuck.Type + " has " + copiedDuck.Legs + " legs");

            Console.ReadLine();
        }
    }
}
