using Microsoft.AspNetCore.Mvc;

namespace Phozogy.Controllers
{
    public class PricingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}