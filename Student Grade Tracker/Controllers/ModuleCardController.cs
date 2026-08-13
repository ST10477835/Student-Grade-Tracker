using Microsoft.AspNetCore.Mvc;

namespace Student_Grade_Tracker.Controllers
{
    public class ModuleCardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
