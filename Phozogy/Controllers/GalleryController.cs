using Microsoft.AspNetCore.Mvc;

namespace Phozogy.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}