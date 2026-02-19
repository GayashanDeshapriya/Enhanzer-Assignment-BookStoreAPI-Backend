using BookManagementAPI.DTOs;
using BookManagementAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookManagementAPI.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        // GET /api/books
        [HttpGet("")]
        public IActionResult GetAll() => Ok(_bookService.GetAll());

        // GET /api/books/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var book = _bookService.GetById(id);
            if (book == null) return NotFound();
            return Ok(book);
        }

        // POST /api/books
        [HttpPost("")]
        public IActionResult Create([FromBody] CreateBookDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var createdBook = _bookService.Create(dto);
            return CreatedAtAction(nameof(GetById), new { id = createdBook.Id }, createdBook);
        }

        // PUT /api/books/5
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UpdateBookDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var updatedBook = _bookService.Update(id, dto);
            if (updatedBook == null) return NotFound();
            return Ok(updatedBook);
        }

        // DELETE /api/books/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _bookService.Delete(id);
            return NoContent();
        }
    }
}
