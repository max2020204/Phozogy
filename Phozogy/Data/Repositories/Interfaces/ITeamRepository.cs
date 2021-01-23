using Phozogy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phozogy.Data.Repositories.Interfaces
{
    public interface ITeamRepository
    {
        IQueryable<TeamModel> Team();
        TeamModel GetTeamById(int id);
        TeamModel GetTeamByFullName(string name);
        void SaveTeam(TeamModel team);
        void DeleteReview(int id);
    }
}
