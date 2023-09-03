using Phozogy.Models;
using System.Linq;

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