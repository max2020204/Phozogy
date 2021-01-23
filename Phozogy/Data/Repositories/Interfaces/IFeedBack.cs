
using Phozogy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phozogy.Data.Repositories.Interfaces
{
   public interface IFeedBack
    {
      
        IQueryable<FeedBackModel> FeedBacks();
        FeedBackModel GetFeedBackById(int id);
        FeedBackModel GetEmail(string email);
        IQueryable<FeedBackModel> GetNames(string name);
        IQueryable<FeedBackModel> GetWebsites(string web);
        FeedBackModel GetEmail(FeedBackModel email);
        void SaveFeedBack(FeedBackModel feedBack);
        void DeleteFeedBack(int id);
    }
}
