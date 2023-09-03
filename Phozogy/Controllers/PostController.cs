using Microsoft.AspNetCore.Mvc;
using Phozogy.Data;
using Phozogy.Models;
using System;

namespace Phozogy.Controllers
{
    public class PostController : Controller
    {
        private readonly DataManager _data;

        public PostController(DataManager data)
        {
            _data = data;
        }

        public IActionResult Index()
        {
            return View(_data);
        }

        [Route("post/{id}")]
        public IActionResult Index(int id)
        {
            _data.Post.PostModel = _data.Post.GetPostById(id);
            return View(_data);
        }

        [HttpGet]
        public IActionResult Comments()
        {
            return View(_data);
        }

        [HttpPost]
        [Route("post/{id}")]
        public IActionResult Comments(CommentModel model)
        {
            model.Date = DateTime.Now.Date.ToShortDateString();
            _data.Comment.SaveComment(model);
            return RedirectToAction("Index", new { id = model.PostId });
        }
    }
}