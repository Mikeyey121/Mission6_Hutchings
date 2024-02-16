namespace MusicApplication.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Music
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Category { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [Range(1900, 2100, ErrorMessage = "Year must be between 1900 and 2100")] // Assuming year range for movies/books etc.
        public int Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; }

        public bool? Edited { get; set; } = false; // Default to false, as it's not required

        public string? Lent { get; set; }

        [MaxLength(25, ErrorMessage = "Notes cannot be more than 25 characters long.")]
        public string? Notes { get; set; }
    }

}

