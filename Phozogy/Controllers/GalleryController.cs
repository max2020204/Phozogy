using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
