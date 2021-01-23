using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Phozogy.Data;
using Phozogy.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Phozogy.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        DataManager data;

        public HomeController(ILogger<HomeController> logger, DataManager context)
        {
            _logger = logger;
            this.data = context;
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
            EmailSender email = data.Email.GetEmail(emails);
            if (email == null)
            {
                var temp = new EmailSender
                {
                    Id = default,
                    Email = emails
                };
                data.Email.SaveEmail(temp);
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
