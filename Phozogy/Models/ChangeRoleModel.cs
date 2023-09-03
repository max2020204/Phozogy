﻿using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Phozogy.Models
{
    public class ChangeRoleModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public List<IdentityRole> AllRoles { get; set; }
        public IList<string> UserRoles { get; set; }

        public ChangeRoleModel()
        {
            AllRoles = new List<IdentityRole>();
            UserRoles = new List<string>();
        }
    }
}