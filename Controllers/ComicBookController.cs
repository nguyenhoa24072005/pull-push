using ComicRentalSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ComicRentalSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComicBookController : ControllerBase
    {
        private readonly ComicSystemContext _context;

        public ComicBookController(ComicSystemContext context)
        {
            _context = context;
        }

        // GET: api/ComicBook
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ComicBook>>> GetComicBooks()
        {
            return await _context.ComicBooks.ToListAsync();
        }

        // GET: api/ComicBook/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ComicBook>> GetComicBook(int id)
        {
            var comicBook = await _context.ComicBooks.FindAsync(id);

            if (comicBook == null)
            {
                return NotFound();
            }

            return comicBook;
        }

        // POST: api/ComicBook
        [HttpPost]
        public async Task<ActionResult<ComicBook>> PostComicBook(ComicBook comicBook)
        {
            _context.ComicBooks.Add(comicBook);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetComicBook), new { id = comicBook.ComicBookID }, comicBook);
        }
    }
}
