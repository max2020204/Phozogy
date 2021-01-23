using Microsoft.EntityFrameworkCore;
using Phozogy.Data.Repositories.Interfaces;
using Phozogy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phozogy.Data.Repositories.EntityFramework
{
    public class EFFeedBack : IFeedBack
    {
        AppDbContext context { get; set; }
        public EFFeedBack(AppDbContext context)
        {
            this.context = context;
        }
        public void DeleteFeedBack(int id)
        {
            context.FeedBack.Remove(new FeedBackModel() { Id = id });
            context.SaveChanges();
        }

        public IQueryable<FeedBackModel> FeedBacks()
        {
            return context.FeedBack.OrderBy(x => x.Id);
        }

        public FeedBackModel GetEmail(string email)
        {
            return context.FeedBack.FirstOrDefault(x => x.Email == email);
        }

        public FeedBackModel GetEmail(FeedBackModel email)
        {
            return context.FeedBack.FirstOrDefault(x => x.Email == email.Email);
        }

        public FeedBackModel GetFeedBackById(int id)
        {
            return context.FeedBack.FirstOrDefault(x => x.Id == id);
        }

        public void SaveFeedBack(FeedBackModel feedBack)
        {
            if (feedBack.Id == default)
                context.Entry(feedBack).State = EntityState.Added;
            else
                context.Entry(feedBack).State = EntityState.Modified;
            context.SaveChanges();
        }

        public IQueryable<FeedBackModel> GetNames(string name)
        {
            return context.FeedBack.OrderBy(x => x.Name == name);
        }

        public IQueryable<FeedBackModel> GetWebsites(string web)
        {
            return context.FeedBack.OrderBy(x => x.Website == web);
        }
    }
}
