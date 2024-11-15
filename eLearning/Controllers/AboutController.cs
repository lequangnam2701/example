using Microsoft.AspNetCore.Mvc;

namespace eLearning.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
