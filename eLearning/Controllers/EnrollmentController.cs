using Microsoft.AspNetCore.Mvc;

namespace eLearning.Controllers
{
    public class EnrollmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
