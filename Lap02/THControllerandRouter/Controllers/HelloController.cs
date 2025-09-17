using Microsoft.AspNetCore.Mvc;

namespace THControllerandRouter.Controllers
{
    public class HelloController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        //http get Hello/Welcome1
        public IActionResult Welcome1()
        {
            return View();
        }
        //http get Hello/Hello1
        public string Index()
        {
            return "This is my default action...";
        }
        //Index is default action point //
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
