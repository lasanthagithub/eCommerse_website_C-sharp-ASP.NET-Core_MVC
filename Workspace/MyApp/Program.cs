using Newtonsoft.Json;
using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create product object -use several lines

            //Product product1 = new Product();
            //product1.ID = 101;
            //product1.Name = "Red apple";
            //product1.Price = 1.99M;

            // Create product object -use onlu one line
            var product1 = new Product { ID = 101, Name = "Red aplle", Price = 1.99M};

            // Serialize the product object to JSON string
            var jsonString = JsonConvert.SerializeObject(product1);

        }
    }
    // Create model
    class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
