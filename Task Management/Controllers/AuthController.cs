using Microsoft.AspNetCore.Mvc;

namespace Task_Management.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
