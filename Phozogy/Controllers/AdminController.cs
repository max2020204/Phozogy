using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Phozogy.Data;
using Phozogy.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Phozogy.Controllers
{

    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        DataManager data;
        IWebHostEnvironment _appEnvironment;
        public AdminController(DataManager data, SignInManager<User> user, IWebHostEnvironment appEnvironment)
        {
            this.data = data;
            _appEnvironment = appEnvironment;
        }
        public async Task<IActionResult> Index(int page = 1)
        {
            return View(data);
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
            PostModel newpost = new PostModel
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
            BlogModel blog = new BlogModel
            {
                Date = DateTime.Now.ToShortDateString(),
                Short_Description = post.Short_Description,
                Image = "img/Files/" + MainPhoto.FileName,
                Title = post.Title,
                Type = post.Type,
            };

            if (ModelState.IsValid)
            {
                data.Post.SavePost(newpost);
                data.Blog.SaveBlog(blog);
            }
            else
            {
                data.Post.SavePost(newpost);
                data.Blog.SaveBlog(blog);


            }


            return RedirectToAction("Index");
        }
    }
}
