using Microsoft.AspNetCore.Mvc;
using Phozogy.Data;
using Phozogy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phozogy.Controllers
{
    public class AboutController : Controller
    {
        DataManager data;
        public AboutController(DataManager data)
        {
            this.data = data;
        }
        public IActionResult Index()
        {
            return View(data);
        }

    }
}
