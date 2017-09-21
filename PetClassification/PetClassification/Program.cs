using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetClassification
{
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

    class Program
    {
        static void Main(string[] args)
        {
            PetStruct dog;
            dog.Type = "Dog";
            dog.Legs = 4;
            dog.HasFur = true;

            PetClass duck = new PetClass();
            duck.Type = "Duck";
            duck.Legs = 2;
            duck.HasFur = false;


            Console.ReadLine();
        }
    }
}
