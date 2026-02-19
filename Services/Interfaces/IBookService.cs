using BookManagementAPI.DTOs;

namespace BookManagementAPI.Services.Interfaces
{
    public interface IBookService
    {
        List<BookDto> GetAll();
        BookDto GetById(int id);
        BookDto Create(CreateBookDto dto);
        BookDto Update(int id, UpdateBookDto dto);
        void Delete(int id);
    }
}
