using Phozogy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phozogy.Data.Repositories.Interfaces
{
   public interface IBlogRepository
    {
        IQueryable<BlogModel> Blogs();
        void SaveBlog(BlogModel blog);
        void DeleteBlog(int id);
    }
}
