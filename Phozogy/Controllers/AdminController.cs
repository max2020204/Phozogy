using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Phozogy.Data;
using Phozogy.Models;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Phozogy.Controllers
{
    [Authorize(Roles = "moderator,admin")]
    public class AdminController : Controller
    {
        private readonly DataManager _data;
        private readonly IWebHostEnvironment _appEnvironment;

        public AdminController(DataManager data, IWebHostEnvironment appEnvironment)
        {
            this._data = data;
            _appEnvironment = appEnvironment;
        }

        public IActionResult Index()
        {
            return View(_data);
        }

        [HttpGet]
        public IActionResult AddPost()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddPost(PostModel post, IFormFile MainPhoto)
        {
            // путь к папке Files
            string path = "\\img\\Files\\" + MainPhoto.FileName;
            using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
            {
                await MainPhoto.CopyToAsync(fileStream);
            }
            PostModel newpost = new()
            {
                Type = post.Type,
                MainPhoto = "\\\\img\\\\Files\\\\" + MainPhoto.FileName,
                Image = "/img/Files/" + MainPhoto.FileName,
                Description = post.Description,
                Title = post.Title,
                Short_Description = post.Short_Description,
                Tags = post.Tags,
                Date = DateTime.Now.ToShortDateString()
            };
            BlogModel blog = new()
            {
                Date = DateTime.Now.ToShortDateString(),
                Short_Description = post.Short_Description,
                Image = "img/Files/" + MainPhoto.FileName,
                Title = post.Title,
                Type = post.Type,
            };

            if (ModelState.IsValid)
            {
                _data.Post.SavePost(newpost);
                _data.Blog.SaveBlog(blog);
            }
            else
            {
                _data.Post.SavePost(newpost);
                _data.Blog.SaveBlog(blog);
            }

            return RedirectToAction("Index");
        }
    }
}