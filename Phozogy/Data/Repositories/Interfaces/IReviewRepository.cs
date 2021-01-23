using Phozogy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phozogy.Data.Repositories.Interfaces
{
    public interface IReviewRepository
    {
        IQueryable<ReviewModel> Reviews();
        ReviewModel GetReviewById(int id);
        ReviewModel GetReviewByFullName(string name);
        void SaveReview(ReviewModel review);
        void DeleteReview(int id);
    }
}
