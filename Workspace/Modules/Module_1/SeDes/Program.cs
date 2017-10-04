using System;

namespace SeDes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var product = new Productn {ID = 101, Name = "Product-101", Price = 99 };


            var productJson = JsonConvert.SerializeObject(product);
            Console.WriteLine(productJson);

            var productDeserilize = JsonConvert.DeserializeObject<Product>(productJson);
            Console.WriteLine(productDeserilize);
        }
    }
}
