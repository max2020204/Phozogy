using Microsoft.EntityFrameworkCore;
using Phozogy.Data.Repositories.Interfaces;
using Phozogy.Models;
using System.Collections.Generic;
using System.Linq;

namespace Phozogy.Data.Repositories.EntityFramework
{
    public class EFPost : IPostRepository
    {
        public AppDbContext context { get; set; }
        public PostModel PostModel { get; set; }

        public EFPost(AppDbContext context)
        {
            this.context = context;
        }

        public void DeletePost(int id)
        {
            int prev = id - 1;
            PostModel post = context.Post.FirstOrDefault(x => x.Id == id);
            context.Entry(post).State = EntityState.Deleted;
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

        public PostModel GetPrevPost(PostModel post)
        {
            List<PostModel> posts = context.Post.OrderBy(x => x.Id).ToList();
            int newid = posts.IndexOf(post);
            return posts[newid - 1];
        }

        public PostModel GetNextPost(PostModel post)
        {
            List<PostModel> posts = context.Post.OrderBy(x => x.Id).ToList();
            int newid = posts.IndexOf(post);
            if (GetPostCount() - 1 == newid)
            {
                return posts[newid];
            }
            else
            {
                return posts[newid + 1];
            }
        }

        public int GetPostCount()
        {
            return context.Post.Count();
        }
    }
}