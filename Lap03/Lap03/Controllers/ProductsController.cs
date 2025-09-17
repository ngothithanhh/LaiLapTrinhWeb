using Lap03.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lap03.Controllers
{
    public class ProductsController : Controller
    {
        protected Products product = new Products();
        //protected Categories category = new Categories();
        public IActionResult Index()
        {
            var products = product.GetProductsList();
            //var categories = category.GetCategoriesList();
            //ViewBag.Categories = categories;

            return View(products);
        }
    }
}
