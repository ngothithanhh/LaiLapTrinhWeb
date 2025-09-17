using Lap03.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lap03.Controllers
{
    public class CategoriesController : Controller
    {
        protected Categories category = new Categories();
        //public IActionResult Index()
        //{
        //    var categories = category.GetCategoriesList();
        //    return View(categories);
        //}

        public PartialViewResult CategoryMenu()
        {
            var categories = category.GetCategoriesList();
            return PartialView(categories);
        }
    }
}
