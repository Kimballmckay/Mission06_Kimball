using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Kimball.Models
{
    public class Movie
    {
        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        
        [Key]
        [Required]
        public int MovieId { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Year is required.")]
        [Range(1888, 2025, ErrorMessage = "Year must be between 1888 and 2025.")]
        public int Year { get; set; }

        public string? Director { get; set; }

        public string? Rating { get; set; }

        public bool Edited { get; set; }

        [MaxLength(25, ErrorMessage = "Lent cannot exceed 25 characters.")]
        public string? LentTo { get; set; }

        public bool CopiedToPlex { get; set; }

        [MaxLength(25, ErrorMessage = "Notes cannot exceed 25 characters.")]
        public string? Notes { get; set; }
    }
}
