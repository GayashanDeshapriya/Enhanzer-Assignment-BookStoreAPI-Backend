using BookManagerAPI.Models.Entities;
using BookManagerAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookManagerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetBooks() => Ok(BookStore.Books);



        [HttpPost]
        public IActionResult AddBook([FromBody] Book book)
        {
            book.Id = BookStore.Books.Count + 1;
            BookStore.Books.Add(book);
            return CreatedAtAction(nameof(GetBooks), new { id = book.Id }, book);
        }

        [HttpGet("{id}")]
        public IActionResult GetBook(int id)
        {
            var book = BookStore.Books.FirstOrDefault(b => b.Id == id);
            if (book == null) return NotFound();
            return Ok(book);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id, [FromBody] Book updatedBook)
        {
            var book = BookStore.Books.FirstOrDefault(b => b.Id == id);
            if (book == null) return NotFound();
            book.Title = updatedBook.Title;
            book.Author = updatedBook.Author;
            book.ISBN = updatedBook.ISBN;
            book.PublicationDate = updatedBook.PublicationDate;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            var book = BookStore.Books.FirstOrDefault(b => b.Id == id);
            if (book == null) return NotFound();
            BookStore.Books.Remove(book);
            return NoContent();
        }
    }

}
