using Microsoft.AspNetCore.Mvc;

namespace EAD_Project_MVC.Controllers
{
    public class TestController : Controller
    {
        public ViewResult ActionMethod()
        {
            return View("Index");
        }
    }
}
