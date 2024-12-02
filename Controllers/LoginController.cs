using Microsoft.AspNetCore.Mvc;

namespace eLearning.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
