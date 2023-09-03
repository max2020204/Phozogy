using System.ComponentModel.DataAnnotations;

namespace Phozogy.Models
{
    public class BlogModel
    {
        public int id { get; set; }
        public string Type { get; set; }

        [Required]
        [Display(Name = "Image")]
        public string Image { get; set; }

        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Short Description")]
        public string Short_Description { get; set; }

        public string Date { get; set; }
    }
}