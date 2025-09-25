using Microsoft.AspNetCore.Mvc;
using ModelLss.Models;

namespace ModelLss.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult user()
        {
            var objuser = new User();
            objuser.Id = 1;
            objuser.Username = "JohnDoe";
            objuser.Email = "abcxyz@gmail.com";
            objuser.PasswordHash = "12345";
            ViewBag.objuser = objuser;
            return View();
        }
    }
}
