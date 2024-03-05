using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessObject.Models;
using DataAccess.Repository;

namespace eBookStoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _context;

        public AuthorsController(IAuthorRepository context)
        {
            _context = context;
        }

        // GET: api/Authors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Author>>> GetAuthor()
        {
          if (_context.GetAllAuthors == null)
          {
              return NotFound();
          }
            return await _context.GetAllAuthors();
        }

        // GET: api/Authors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Author>> GetAuthor(int id)
        {
          if (_context.GetAllAuthors() == null)
          {
              return NotFound();
          }
            var author = await _context.GetAuthorById(id);

            if (author == null)
            {
                return NotFound();
            }

            return author;
        }

        // PUT: api/Authors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAuthor(int id, Author author)
        {
            if (id != author.Author_Id)
            {
                return BadRequest();
            }
                await _context.UpdateAuthor(author);

            return Ok(author);
        }

        // POST: api/Authors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Author>> PostAuthor(Author author)
        {
          if (_context.GetAllAuthors() == null)
          {
              return Problem("Entity set 'Author'  is null.");
          }
            await _context.AddNewAuthor(author);

            return CreatedAtAction("GetAuthor", new { id = author.Author_Id }, author);
        }

        // DELETE: api/Authors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAuthor(int id)
        {
            if (_context.GetAllAuthors() == null)
            {
                return NotFound();
            }
            var author = await _context.GetAuthorById(id);
            if (author == null)
            {
                return NotFound();
            }

            await _context.DeleteAuthor(id);
            return NoContent();
        }
    }
}
