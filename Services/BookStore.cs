using BookManagerAPI.Models.Entities;

namespace BookManagerAPI.Services
{
    public static class BookStore
    {
        // Static list to store books
        public static List<Book> Books { get; set; } = new List<Book>();
    }
}
