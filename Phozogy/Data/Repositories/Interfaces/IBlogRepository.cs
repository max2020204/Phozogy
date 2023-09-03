using Phozogy.Models;
using System.Linq;

namespace Phozogy.Data.Repositories.Interfaces
{
    public interface IBlogRepository
    {
        IQueryable<BlogModel> Blogs();

        void SaveBlog(BlogModel blog);

        void DeleteBlog(int id);
    }
}