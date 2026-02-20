using BookManagementAPI.DTOs;
using BookManagementAPI.Models;
using BookManagementAPI.Repositories.Interfaces;

namespace BookManagementAPI.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly List<Book> _books = new();

        public List<Book> GetAll() => _books;

        public void Add(Book book)
        {
            book.Id = _books.Any() ? _books.Max(b => b.Id) + 1 : 1;
            _books.Add(book);
        }

        public void Delete(Book book)
        {
            var existingBook = GetById(book.Id);
            _books.Remove(existingBook);

        }
        public Book GetById(int id)
        {
           Book? book = _books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                throw new KeyNotFoundException($"Book with Id {id} not found.");
            }
            return book;
        }

        public void Update(Book book)
        {
            var existingBook = GetById(book.Id);
            if (book == null)
            {
                throw new KeyNotFoundException($"Book not found.");
            }

            // Update properties
            existingBook.Title = book.Title;
            existingBook.Author = book.Author;
            existingBook.Isbn = book.Isbn;
            existingBook.PublicationDate = book.PublicationDate;

        }
    }
}
