using Phozogy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phozogy.Data.Repositories.Interfaces
{
    public interface ICommentRepository
    {
        IQueryable<CommentModel> Comments(int post);
        void SaveComment(CommentModel comment);
        void DeleteComment(int id);
    }
}
