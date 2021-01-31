using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phozogy.Models
{
    public class AdminView :IndexViewModel
    {
        public SignInManager<User> user { get; set; }
    }
}
