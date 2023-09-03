using System.ComponentModel.DataAnnotations;

namespace Phozogy.Models
{
    public class ReviewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string PhotoPath { get; set; }

        [Required]
        public string Review { get; set; }
    }
}