using Microsoft.AspNetCore.Mvc;

namespace Task_Management.Controllers
{
    public class TasksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
