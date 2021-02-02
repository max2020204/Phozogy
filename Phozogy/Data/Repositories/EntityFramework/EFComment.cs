using Microsoft.EntityFrameworkCore;
using Phozogy.Data.Repositories.Interfaces;
using Phozogy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phozogy.Data.Repositories.EntityFramework
{
    public class EFComment : ICommentRepository
    {
        public AppDbContext context { get; set; }
        public EFComment(AppDbContext context)
        {
            this.context = context;
        }
        public IQueryable<CommentModel> Comments(int post)
        {
            return context.Comments.Where(x => x.PostId == post);
        }

        public void DeleteComment(int id)
        {
            CommentModel comment = context.Comments.FirstOrDefault(x => x.id == id);
            context.Entry(comment).State = EntityState.Deleted;
            context.SaveChanges();
        }

        public void SaveComment(CommentModel comment)
        {
            if (comment.id == default)
                context.Entry(comment).State = EntityState.Added;
            else
                context.Entry(comment).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
