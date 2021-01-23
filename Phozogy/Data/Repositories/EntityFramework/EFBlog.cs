using Microsoft.EntityFrameworkCore;
using Phozogy.Data.Repositories.Interfaces;
using Phozogy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phozogy.Data.Repositories.EntityFramework
{
    public class EFBlog : IBlogRepository
    {
        public AppDbContext context { get; set; }
        public EFBlog(AppDbContext context)
        {
            this.context = context;
        }
        public IQueryable<BlogModel> Blogs()
        {
            return context.Blog.OrderBy(x => x.id);
        }

        public void DeleteBlog(int id)
        {
            context.Blog.Remove(new BlogModel() { id = id });
            context.SaveChanges();
        }

        public void SaveBlog(BlogModel blog)
        {
            if (blog.id == default)
                context.Entry(blog).State = EntityState.Added;
            else
                context.Entry(blog).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
