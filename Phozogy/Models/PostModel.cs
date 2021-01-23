using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Phozogy.Models
{
    public class PostModel
    {
        [Key]
        public int Id { get; set; }
        public string MainPhoto { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }
    }
}
