using Microsoft.AspNetCore.Identity;
using System;

namespace Phozogy.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Date { get; set; }
    }
}