using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NetCoreLAB6_EF.Models;

namespace NetCoreLAB6_EF.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Product()
        {
            var product = new Product();
            //{
            //    Id = 1,
            //    Name = "Product Name 1",
            //    Description = "Túi xách",
            //    Image = "/images/products/product1.jpg"
            //};
            //new Product
            //{
            //    Id = 2,
            //    Name = "Product Name 2",
            //    Description = "Túi xách",
            //    Image = "/images/products/product2.jpg"
            //};
            //new Product
            //{
            //    Id = 3,
            //    Name = "Product Name 3",
            //    Description = "Túi xách",
            //    Image = "/images/products/product3.jpg"
            //};
            //new Product
            //{
            //    Id = 4,
            //    Name = "Product Name 4",
            //    Description = "Túi xách",
            //    Image = "/images/products/product4.jpg"
            //};
            ViewBag.Product = product;
            return View();
        }
    }
}
