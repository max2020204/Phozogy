using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Phozogy.Models
{
    public class CommentModel
    {
        [Key]
        public int id { get; set; }
        public int PostId { get; set; }
        public string Date { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public string Comment { get; set; }
    }
}
