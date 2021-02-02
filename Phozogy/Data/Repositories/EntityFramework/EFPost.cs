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

        public PostModel GetPrevPost(int id)
        {
            PostModel[] posts = context.Post.OrderBy(x => x.Id).ToArray();
            int newid = 0;
            for (int i = 0; i < posts.Length; i++)
            {
                if (posts[i].Id == id)
                {
                    newid = i;
                    break;
                }
            }
            return posts[newid - 1];
        }

        public PostModel GetNextPost(int id)
        {
            PostModel[] posts = context.Post.OrderBy(x => x.Id).ToArray();
            int newid = 0;
            for (int i = 0; i < posts.Length; i++)
            {
                if (posts[i].Id == id)
                {
                    newid = i;
                    break;
                }
            }
            try
            {
                return posts[newid + 1];
            }
            catch (Exception)
            {

                return posts[newid];
            }

        }
        public int GetPostCount()
        {
            return context.Post.OrderBy(x => x.Id).Last().Id;
        }
    }
}
