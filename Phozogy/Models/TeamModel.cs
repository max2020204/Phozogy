using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Phozogy.Models
{
    public class TeamModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string PhotoPath { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Profession { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string YouTube { get; set; }
        public string Instagram { get; set; }
    }
}
