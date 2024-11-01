using Lab8.Models;
using Microsoft.AspNetCore.Mvc;


namespace Lab8.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product { ID = 1, Name = "Laptop", Price = 999.99m, CreatedDate = DateTime.Now.AddDays(-10) },
                new Product { ID = 2, Name = "Phone", Price = 499.99m, CreatedDate = DateTime.Now.AddDays(-5) },
                new Product { ID = 3, Name = "Tablet", Price = 299.99m, CreatedDate = DateTime.Now }
            };

            return View(products);
        }
    }
}
