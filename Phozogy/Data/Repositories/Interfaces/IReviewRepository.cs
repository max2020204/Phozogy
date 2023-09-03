using Phozogy.Models;
using System.Linq;

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