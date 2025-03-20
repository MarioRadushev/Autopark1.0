using Microsoft.AspNetCore.Mvc;

namespace Autopark.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}

