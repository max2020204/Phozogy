using Phozogy.Models;
using System.Linq;

namespace Phozogy.Data.Repositories.Interfaces
{
    public interface ICommentRepository
    {
        IQueryable<CommentModel> Comments(int post);

        void SaveComment(CommentModel comment);

        void DeleteComment(int id);
    }
}