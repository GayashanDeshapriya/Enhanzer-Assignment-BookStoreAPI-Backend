using System.ComponentModel.DataAnnotations;

namespace BookManagementAPI.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string? Title { get; set; }

        [Required]
        [MaxLength(150)]
        public string? Author { get; set; }

        [Required]
        public string? Isbn { get; set; }

        public DateOnly PublicationDate { get; set; }
    }
}
