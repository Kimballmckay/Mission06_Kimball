using System.ComponentModel.DataAnnotations;

namespace Mission06_Kimball.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieID { get; set; }

        [Required(ErrorMessage = "Category is required.")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Year is required.")]
        public string Year { get; set; }

        [Required(ErrorMessage = "Director is required.")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Rating is required.")]
        public string Rating { get; set; }

        public bool Edited { get; set; }

        [MaxLength(25, ErrorMessage = "Lent cannot exceed 25 characters.")]
        public string? Lent { get; set; }

        [MaxLength(25, ErrorMessage = "Notes cannot exceed 25 characters.")]
        public string? Notes { get; set; }
    }
}
