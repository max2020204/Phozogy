using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Phozogy.Data;
using Phozogy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phozogy.Controllers
{

    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        DataManager data;
        SignInManager<User> user;
        public AdminController(DataManager data, SignInManager<User> user)
        {
            this.data = data;
            this.user = user;
        }
        public async Task<IActionResult> Index(int page =1)
        {
            int pageSize = 5;
            IQueryable<BlogModel> source = data.Blog.Blogs();
            var count = await source.CountAsync();
            var items = await source.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            AdminView viewModel = new AdminView
            {
                Blog = items,
                PageView = pageViewModel,
                user = user
            };
            return View(viewModel);
        }
        public IActionResult AddPost(PostModel post)
        {
            if (ModelState.IsValid)
            {
                data.Post.SavePost(post);
            }
            return RedirectToAction("Index");
        }
    }
}
