namespace MusicApplication.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using MovieModel.Models;

    public class Movies
    {
        [Key]
        public int MovieId { get; set; }

        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }

        public Category? Category { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [Range(1888, 2100, ErrorMessage = "Year must be between 1888 and 2100")] 
        public int Year { get; set; }

        public string? Director { get; set; }

        public string? Rating { get; set; }
        [Required]
        public bool Edited { get; set; } = false; // Default to false, as it's not required

        public string? LentTo { get; set; }
        [Required]
        public bool CopiedToPlex { get; set; } = false;

        [MaxLength(25, ErrorMessage = "Notes cannot be more than 25 characters long.")]
        public string? Notes { get; set; }
    }
    

}

