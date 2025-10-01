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
                ViewBag.Message = "Nhap sai do dai mat khau roi :>>";
                return View();
            }
            else
            {
                return Content("Ban da nhap mk thanh cong!!");
            }

            if (ModelState.IsValid)
            {
                return Content("Ban da dang ky thanh cong");
            }
            else
            {
                return View();
            }
        }

        public IActionResult UserAnnotation()
        {
            return View();
        }

        
    }
}
