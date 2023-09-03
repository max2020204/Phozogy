using Microsoft.EntityFrameworkCore;
using Phozogy.Data.Repositories.Interfaces;
using Phozogy.Models;
using System.Linq;

namespace Phozogy.Data.Repositories.EntityFramework
{
    public class EFEmail : IEmailRepository
    {
        private AppDbContext context { get; set; }

        public EFEmail(AppDbContext context)
        {
            this.context = context;
        }

        public void DeleteEmail(int id)
        {
            EmailSender sender = context.Email.FirstOrDefault(x => x.Id == id);
            context.Entry(sender).State = EntityState.Deleted;
            context.SaveChanges();
        }

        public EmailSender GetEmail(string email)
        {
            return context.Email.FirstOrDefault(x => x.Email == email);
        }

        public EmailSender GetEmailById(int id)
        {
            return context.Email.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<EmailSender> Emails()
        {
            return context.Email.OrderBy(x => x.Id);
        }

        public void SaveEmail(EmailSender email)
        {
            if (email.Id == default)
                context.Entry(email).State = EntityState.Added;
            else
                context.Entry(email).State = EntityState.Modified;
            context.SaveChanges();
        }

        public EmailSender GetEmail(EmailSender email)
        {
            return context.Email.FirstOrDefault(x => x.Email == email.Email);
        }
    }
}