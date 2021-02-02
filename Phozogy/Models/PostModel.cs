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
        [Required]
        [Display(Name = "Type")]
        public string Type { get; set; }
        [Required]
        [Display(Name = "Photo")]
        public string MainPhoto { get; set; }
        [Required]
        [Display(Name = "Short Decription")]
        public string Short_Description { get; set; }
        public string Date { get; set; }
        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Tags")]
        public string Tags { get; set; }
    }
}
