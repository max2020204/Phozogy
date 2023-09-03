using Microsoft.AspNetCore.Mvc;
using Phozogy.Data;

namespace Phozogy.Controllers
{
    public class AboutController : Controller
    {
        private readonly DataManager _data;

        public AboutController(DataManager data)
        {
            this._data = data;
        }

        public IActionResult Index()
        {
            return View(_data);
        }
    }
}