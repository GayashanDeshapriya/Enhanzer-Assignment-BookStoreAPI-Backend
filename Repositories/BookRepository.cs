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
            throw new NotImplementedException();
        }
        public Book GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
