using Microsoft.AspNetCore.Mvc;

namespace Library_Management_System.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProfileIndex()
        {
            return View();
        }
    }
}
