using BookManagementAPI.DTOs;
using BookManagementAPI.Models;
using BookManagementAPI.Repositories.Interfaces;
using BookManagementAPI.Services.Interfaces;

namespace BookManagementAPI.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public BookDto Create(CreateBookDto dto)
        {
            var book = new Book
            {
                Title = dto.Title,
                Author = dto.Author,
                Isbn = dto.Isbn,
                PublicationDate = dto.PublicationDate
            };

            _bookRepository.Add(book);
            return MapToDto(book) ;
        }

        public void Delete(int id)
        {
            var book = _bookRepository.GetById(id);
            if (book != null) _bookRepository.Delete(book);
        }

        public List<BookDto> GetAll()
        {
            return _bookRepository.GetAll().Select(MapToDto).ToList();
        }

        public BookDto GetById(int id)
        {
            var book = _bookRepository.GetById(id);
            return MapToDto(book);
        }

        public BookDto Update(int id, UpdateBookDto dto)
        {
            var book = _bookRepository.GetById(id);

            if (book == null)
            {
                throw new Exception("Book not found");
            }

            book.Title = dto.Title;
            book.Author = dto.Author;
            book.Isbn = dto.Isbn;
            book.PublicationDate = dto.PublicationDate;

            _bookRepository.Update(book);
            return MapToDto(book);
        }

        private BookDto MapToDto(Book book) =>
        new()
        {
            Id = book.Id,
            Title = book.Title,
            Author = book.Author,
            Isbn = book.Isbn,
            PublicationDate = book.PublicationDate
        };
    }
}
