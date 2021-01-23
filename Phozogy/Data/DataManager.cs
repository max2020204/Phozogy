using Phozogy.Data.Repositories.Interfaces;
using Phozogy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phozogy.Data
{
    public class DataManager
    {
        public ICommentRepository Comment { get; set; }
        public IBlogRepository Blog { get; set; }
        public IPostRepository Post { get; set; }
        public IReviewRepository Review { get; set; }
        public ITeamRepository Team { get; set; }
        public IEmailRepository Email { get; set; }
        public IFeedBack FeedBack { get; set; }
        public DataManager(IReviewRepository review, ITeamRepository team, IEmailRepository email, IFeedBack feed, IBlogRepository blog, IPostRepository post, ICommentRepository comment)
        {
            Review = review;
            Team = team;
            Email = email;
            FeedBack = feed;
            Blog = blog;
            Post = post;
            Comment = comment;
        }
    }
}
