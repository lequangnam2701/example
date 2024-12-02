using Microsoft.AspNetCore.Mvc;

namespace eLearning.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
