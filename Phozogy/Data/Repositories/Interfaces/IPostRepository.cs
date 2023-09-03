using Phozogy.Models;
using System.Linq;

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