using Microsoft.AspNetCore.Mvc;

namespace EAD_Project_MVC.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ViewResult Login()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Login(string username, string password)
        {
            return View("Views/Home/Index.cshtml");
        }
    }
}
