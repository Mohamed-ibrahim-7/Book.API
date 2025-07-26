using Book.API.Data;
using Book.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Book.API.Areas.Admin.Controllers
{
    [Route("api/[area]/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BooksController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = await _context.Books
                .Include(b => b.Category)
                .Include(b => b.Author)
                .ToListAsync();
            return Ok(books);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookById(int id)
        {
            var book = await _context.Books
                .Include(b => b.Category)
                .Include(b => b.Author)
                .FirstOrDefaultAsync(b => b.Id == id);

            if (book == null) return NotFound();

            return Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> AddBook([FromBody] book book)
        {
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetBookById), new { id = book.Id }, book);
        }
    }
}
