﻿using Microsoft.EntityFrameworkCore;
using Phozogy.Data.Repositories.Interfaces;
using Phozogy.Models;
using System.Linq;

namespace Phozogy.Data.Repositories.EntityFramework
{
    public class EFTeam : ITeamRepository
    {
        public AppDbContext context { get; set; }

        public EFTeam(AppDbContext context)
        {
            this.context = context;
        }

        public void DeleteReview(int id)
        {
            TeamModel team = context.Team.FirstOrDefault(x => x.Id == id);
            context.Entry(team).State = EntityState.Deleted;
            context.SaveChanges();
        }

        public TeamModel GetTeamByFullName(string name)
        {
            return context.Team.FirstOrDefault(x => x.FullName == name);
        }

        public TeamModel GetTeamById(int id)
        {
            return context.Team.FirstOrDefault(x => x.Id == id);
        }

        public void SaveTeam(TeamModel team)
        {
            if (team.Id == default)
                context.Entry(team).State = EntityState.Added;
            else
                context.Entry(team).State = EntityState.Modified;
            context.SaveChanges();
        }

        public IQueryable<TeamModel> Team()
        {
            return context.Team.OrderBy(x => x.Id);
        }
    }
}