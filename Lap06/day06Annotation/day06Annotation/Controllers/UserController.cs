using day06Annotation.Models;
using Microsoft.AspNetCore.Mvc;

namespace day06Annotation.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UserManual()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UserManual(User user)
        {
            string password = user.Password;
            if(password.Length < 7)
            {
                ViewBag.Message = "Ngu lon nhap sai do dai mat khau roi, ddmm";
                return View();
            }
            else
            {
                return Content("Ban da nhap mk thanh cong!!");
            }
        }

        public IActionResult UserAnnotation()
        {
            return View();
        }
    }
}
