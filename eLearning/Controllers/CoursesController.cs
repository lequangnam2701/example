using Microsoft.AspNetCore.Mvc;

namespace eLearning.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
