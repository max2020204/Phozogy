using Microsoft.EntityFrameworkCore;
using Phozogy.Data.Repositories.Interfaces;
using Phozogy.Models;
using System.Linq;

namespace Phozogy.Data.Repositories.EntityFramework
{
    public class EFReview : IReviewRepository
    {
        private AppDbContext context;

        public EFReview(AppDbContext context)
        {
            this.context = context;
        }

        public ReviewModel GetReviewByFullName(string name)
        {
            return context.Reviews.FirstOrDefault(x => x.FullName == name);
        }

        public ReviewModel GetReviewById(int id)
        {
            return context.Reviews.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<ReviewModel> Reviews()
        {
            return context.Reviews.OrderBy(x => x.Id);
        }

        public void SaveReview(ReviewModel review)
        {
            if (review.Id == default)
                context.Entry(review).State = EntityState.Added;
            else
                context.Entry(review).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteReview(int id)
        {
            ReviewModel review = context.Reviews.FirstOrDefault(x => x.Id == id);
            context.Entry(review).State = EntityState.Deleted;
            context.SaveChanges();
        }
    }
}