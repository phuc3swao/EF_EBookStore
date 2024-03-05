using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessObject.Models;
using DataAccess.Repository;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace eBookStoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ODataController
    {
        private readonly IBookRepository _context;

        public BooksController(IBookRepository context)
        {
            _context = context;
        }

        // GET: api/Books
        [EnableQuery]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {

          var result = await _context.GetAll();
          if (result == null)
          {
              return NotFound();
          }
            return Ok(result);
        }

        // GET: api/Books/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBook(int id)
        {

            //var books = await _context.GetAll();
            //if (books == null)
            //{
            //    return NotFound();
            //}
            var book = await _context.GetById(id);

            if (book == null)
            {
                return NotFound();
            }

            return book;
        }

        // PUT: api/Books/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBook(int id, Book book)
        {
            if (id != book.Bookid)
            {
                return BadRequest();
            }

            try
            {
                await _context.Update(book);
            }
            catch (DbUpdateConcurrencyException)
            {

            }
            return NoContent();
        }

        // POST: api/Books
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Book>> PostBook(Book book)
        {
          if (_context.GetAll() == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Books'  is null.");
          }
            await _context.Add(book);
            return CreatedAtAction("GetBook", new { id = book.Bookid }, book);
        }

        // DELETE: api/Books/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            if (_context.GetAll() == null)
            {
                return NotFound();
            }
            var book = await _context.GetById(id);
            if (book == null)
            {
                return NotFound();
            }

            await _context.Delete(id);
            return NoContent();
        }

    }
}
