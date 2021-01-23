using Microsoft.EntityFrameworkCore;
using Phozogy.Data.Repositories.Interfaces;
using Phozogy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phozogy.Data.Repositories.EntityFramework
{
    public class EFPost : IPostRepository
    {
        public AppDbContext context { get; set; }
        public PostModel PostModel { get ; set ; }

        public EFPost(AppDbContext context)
        {
            this.context = context;
        }
        public void DeletePost(int id)
        {
            context.Post.Remove(new PostModel() { Id = id });
            context.SaveChanges();
        }

        public PostModel GetPostById(int id)
        {
            return context.Post.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<PostModel> Posts()
        {
            return context.Post.OrderBy(x => x.Id);
        }

        public void SavePost(PostModel post)
        {
            if (post.Id == default)
                context.Entry(post).State = EntityState.Added;
            else
                context.Entry(post).State = EntityState.Modified;
            context.SaveChanges();
        }

        public PostModel GetPrevPost(int id)
        {

            return context.Post.FirstOrDefault(x => x.Id == id - 1);
        }

        public PostModel GetNextPost(int id)
        {
            if (id == context.Post.Count())
            {
                return context.Post.FirstOrDefault(x => x.Id == id);
            }
            else
            {
                return context.Post.FirstOrDefault(x => x.Id == id+1);
            }
        }
        public int GetPostCount()
        {
            return context.Post.Count();
        }
    }
}
