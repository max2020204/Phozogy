using Phozogy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phozogy.Data.Repositories.Interfaces
{
    public interface IPostRepository
    {
        int GetPostCount();
        PostModel PostModel { get; set; }
        PostModel GetPrevPost(PostModel post);
        PostModel GetNextPost(PostModel post);
        IQueryable<PostModel> Posts();
        PostModel GetPostById(int id);
        void SavePost(PostModel post);
        void DeletePost(int id);
    }
}
