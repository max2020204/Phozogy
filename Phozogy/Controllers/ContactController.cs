using Microsoft.AspNetCore.Mvc;
using Phozogy.Data;
using Phozogy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phozogy.Controllers
{
    public class ContactController : Controller
    {
        DataManager data;
        public ContactController(DataManager data)
        {
            this.data = data;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult FeedBack()
        {
            return View();
        }
        [HttpPost]
        public IActionResult FeedBack(FeedBackModel model)
        {
            data.FeedBack.SaveFeedBack(model);
            return RedirectToAction("Index");
        }
    }
}
