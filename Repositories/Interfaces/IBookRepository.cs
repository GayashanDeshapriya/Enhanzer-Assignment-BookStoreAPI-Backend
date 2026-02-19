using BookManagementAPI.DTOs;
using BookManagementAPI.Models;

namespace BookManagementAPI.Repositories.Interfaces
{
    public interface IBookRepository
    {
        List<Book> GetAll();
        Book GetById(int id);
        void Add(Book book);
        void Update(Book book);
        void Delete(Book book);
        
    }
}
