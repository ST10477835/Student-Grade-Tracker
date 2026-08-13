using Microsoft.AspNetCore.Mvc;

namespace Student_Grade_Tracker.Controllers
{
    public class GradeElementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
