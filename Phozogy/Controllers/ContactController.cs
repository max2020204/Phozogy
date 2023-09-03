using Microsoft.AspNetCore.Mvc;
using Phozogy.Data;
using Phozogy.Models;

namespace Phozogy.Controllers
{
    public class ContactController : Controller
    {
        private readonly DataManager _data;

        public ContactController(DataManager data)
        {
            _data = data;
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
            _data.FeedBack.SaveFeedBack(model);
            return RedirectToAction("Index");
        }
    }
}