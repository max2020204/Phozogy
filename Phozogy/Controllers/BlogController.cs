using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Phozogy.Data;
using Phozogy.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Phozogy.Controllers
{
    public class BlogController : Controller
    {
        private readonly DataManager _data;

        public BlogController(DataManager data)
        {
            this._data = data;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            int pageSize = 4;
            IQueryable<BlogModel> source = _data.Blog.Blogs().Reverse();
            var count = await source.CountAsync();
            var items = await source.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
            PageViewModel pageViewModel = new(count, page, pageSize);
            IndexViewModel viewModel = new()
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
                _data.Blog.DeleteBlog(id);
                _data.Post.DeletePost(id);
            }
            catch (Exception)
            {
            }
            return RedirectToAction("Index", "Admin");
        }
    }
}