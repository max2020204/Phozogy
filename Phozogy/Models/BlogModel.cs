using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Phozogy.Models
{
    public class BlogModel
    {
        public int id { get; set; }
        public string Type { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Short_Description { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
}
