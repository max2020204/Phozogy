using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Phozogy.Data;
using Phozogy.Models;
using System.Diagnostics;

namespace Phozogy.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataManager _data;

        public HomeController(ILogger<HomeController> logger, DataManager context)
        {
            _logger = logger;
            _data = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string emails)
        {
            EmailSender email = _data.Email.GetEmail(emails);
            if (email == null)
            {
                var temp = new EmailSender
                {
                    Id = default,
                    Email = emails
                };
                _data.Email.SaveEmail(temp);
            }
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}