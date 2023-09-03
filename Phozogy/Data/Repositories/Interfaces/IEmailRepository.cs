using Phozogy.Models;
using System.Linq;

namespace Phozogy.Data.Repositories.Interfaces
{
    public interface IEmailRepository
    {
        IQueryable<EmailSender> Emails();

        EmailSender GetEmailById(int id);

        EmailSender GetEmail(string email);

        EmailSender GetEmail(EmailSender email);

        void SaveEmail(EmailSender email);

        void DeleteEmail(int id);
    }
}