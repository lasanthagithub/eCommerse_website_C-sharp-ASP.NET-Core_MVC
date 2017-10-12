using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebServer.Models;

namespace WebServer.Controllers 
{

    [Route("api/[controller]")]
    public class ProductsController : Controller 
    {
        // Get All products
        [HttpGet]
        public Product[] Get() // or can use GetAllProducts()
        {
            return FakeData.Products.Values.ToArray();
        }

        // Get product by id
        [HttpGet("{id}")]
        public Product Get(int id)  // or can use GetProductById()
        {
            if (FakeData.Products.ContainsKey(id))
                return FakeData.Products[id];
            else
                return null;
        }

        // Add new product
        [HttpPost]
        public Product Post([FromBody]Product product)  // or CreateProduct()
        {
            product.ID = FakeData.Products.Keys.Max() + 1;
            FakeData.Products.Add(product.ID, product);
            return product; // contains the new ID
        }


        // Modify a product
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Product product) 
        {
            if (FakeData.Products.ContainsKey(id)) 
            {
                var target = FakeData.Products[id];
                target.ID = product.ID;
                target.Name = product.Name;
                target.Price = product.Price;
            }
        }

        // Delete a product
        [HttpDelete("{id}")]
        public void Delete(int id) 
        {
            if (FakeData.Products.ContainsKey(id)) 
            {
                FakeData.Products.Remove(id);
            }
        }

    }
}