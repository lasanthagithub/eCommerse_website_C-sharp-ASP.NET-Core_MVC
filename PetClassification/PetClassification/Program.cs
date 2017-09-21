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
            dog.Type = "dog";
            Console.ReadLine();
        }
    }
}
