using MVCStarter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCStarter.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            ViewBag.SomeMessage = "This is a message from a controller";
            List<Product> products = new List<Product>();
            products.Add(new Product() { productId = 1, productName = "Product 1" });
            products.Add(new Product() { productId = 2, productName = "Product 2" });
            products.Add(new Product() { productId = 3, productName = "Product 3" });
            return View(products);
        }

        public ActionResult PartialProduct()
        {
            ViewBag.Message = "Partial data";
            return View();
        }

        public ActionResult ProductDetails()
        {
            return View();
        }

    }
}