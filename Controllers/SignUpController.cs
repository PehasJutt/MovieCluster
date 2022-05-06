using Microsoft.AspNetCore.Mvc;

namespace EAD_Project_MVC.Controllers
{
    public class SignUpController : Controller
    {
        [HttpGet]
        public ViewResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ViewResult SignUp(string username, string password)
        {
            return View("Views/Login/Login.cshtml");
        }
    }
}
