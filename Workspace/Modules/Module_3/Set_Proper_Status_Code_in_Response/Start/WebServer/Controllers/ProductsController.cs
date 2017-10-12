using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebServer.Models;

namespace WebServer.Controllers {

    [Route("api/[controller]")]
    public class ProductsController : Controller {

        
        [HttpGet]
        // before
        //public Product[] Get() {
        //    return FakeData.Products.Values.ToArray();
        //}
        // after
        public ActionResult Get() {
            if (FakeData.Products != null) {
                return Ok(FakeData.Products.Values.ToArray());
            } else {
                return NotFound();
            }
        }
        
        [HttpGet("{id}")]
        // before
        //public Product Get(int id) {
        //    if (FakeData.Products.ContainsKey(id))
        //        return FakeData.Products[id];
        //    else
        //        return null;
        //}


        // after
        public ActionResult Get(int id) {
            if (FakeData.Products.ContainsKey(id))
                return Ok(FakeData.Products[id]);
            else
                return NotFound();
        }   


        [HttpGet("from/{low}/to/{high}")]
        //before
        public Product[] Get(int low, int high) {
            var products = FakeData.Products.Values
            .Where(p => p.Price >= low && p.Price <= high).ToArray();
            return products;
        }
        // after
        public ActionResult Get(int low, int high) {
            var products = FakeData.Products.Values
            .Where(p => p.Price >= low && p.Price <= high).ToArray();
            if (products.Length > 0) { // LINQ guarantees the products won't be null
                return Ok(products);
            } else {
                return NotFound();
            }
        }

        [HttpPost]
        // before
        //public Product Post([FromBody]Product product) {
        //    product.ID = FakeData.Products.Keys.Max() + 1;
        //   FakeData.Products.Add(product.ID, product);
        //    return product; // contains the new ID
        //}
        // after
        public ActionResult Post([FromBody]Product product) {
            product.ID = FakeData.Products.Keys.Max() + 1;
            FakeData.Products.Add(product.ID, product);
            return Created($"api/products/{product.ID}", product); // contains the new ID
            // This is the concept of HATEOAS (Hypermedia as the Engine of Application State).
        }


        [HttpPut("{id}")]
        // before
        //public void Put(int id, [FromBody]Product product) {
        //    if (FakeData.Products.ContainsKey(id)) {
        //        var target = FakeData.Products[id];
        //        target.ID = product.ID;
        //        target.Name = product.Name;
        //        target.Price = product.Price;
        //    }
        //}
        // after
        public ActionResult Put(int id, [FromBody]Product product) {
            if (FakeData.Products.ContainsKey(id)) {
                var target = FakeData.Products[id];
                target.ID = product.ID;
                target.Name = product.Name;
                target.Price = product.Price;
                return Ok();
            } else {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        // before
        //public void Delete(int id) {
        //    if (FakeData.Products.ContainsKey(id)) {
        //        FakeData.Products.Remove(id);
        //    }
        //}

        // afetr
        public ActionResult Delete(int id) {
            if (FakeData.Products.ContainsKey(id)) {
                FakeData.Products.Remove(id);
                return Ok();
            } else {
                return NotFound();
            }
        }
    }
}