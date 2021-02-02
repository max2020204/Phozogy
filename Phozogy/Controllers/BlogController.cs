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
    public class BlogController : Controller
    {
        DataManager data;
        public BlogController(DataManager data)
        {
            this.data = data;
        }
        public async Task<IActionResult> Index(int page = 1)
        {
            int pageSize = 4;
            IQueryable<BlogModel> source = data.Blog.Blogs().Reverse();
            var count = await source.CountAsync();
            var items = await source.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            IndexViewModel viewModel = new IndexViewModel
            {
                Blog = items,
                PageView = pageViewModel
            };
            return View(viewModel);
        }
        public IActionResult Delete(int id)
        {
            try
            {
                data.Blog.DeleteBlog(id);
                data.Post.DeletePost(id);
            }
            catch (Exception)
            {
            }
            return RedirectToAction("Index", "Admin");
        }
    }
}
