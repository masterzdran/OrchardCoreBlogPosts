using Microsoft.AspNetCore.Mvc;

namespace OrchardCoreTheme.Freelancer.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}