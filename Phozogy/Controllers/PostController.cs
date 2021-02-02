using Microsoft.AspNetCore.Mvc;
using Phozogy.Data;
using Phozogy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phozogy.Controllers
{
    public class PostController : Controller
    {
        DataManager data;

        public PostController(DataManager data)
        {
            this.data = data;
        }
        public IActionResult Index()
        {
            return View(data);
        }
        [Route("post/{id}")]
        public IActionResult Index(int id)
        {         
            data.Post.PostModel = data.Post.GetPostById(id);
            return View(data);
        }
        [HttpGet]
        public IActionResult Comments()
        {
            return View(data);
        }

        [HttpPost]
        [Route("post/{id}")]
        public IActionResult Comments(CommentModel model)
        {
            model.Date = DateTime.Now.Date.ToShortDateString();
            data.Comment.SaveComment(model);
            return RedirectToAction("Index", new { id = model.PostId });
        }
    }
}
