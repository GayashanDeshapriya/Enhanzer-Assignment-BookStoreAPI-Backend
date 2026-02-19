using System.ComponentModel.DataAnnotations;

namespace BookManagementAPI.DTOs
{
    public class CreateBookDto
    {
        [Required]
        public string? Title { get; set; }

        [Required]
        public string? Author { get; set; }

        public string? Isbn { get; set; }

        public DateOnly PublicationDate { get; set; }
    }
}
