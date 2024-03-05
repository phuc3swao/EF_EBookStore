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
    public class PublishersController : ControllerBase
    {
        private readonly IPublisherRepository _context;

        public PublishersController(IPublisherRepository context)
        {
            _context = context;
        }

        // GET: api/Publishers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Publisher>>> GetPublisher()
        {
            var result = await _context.GetAll();
          if (result == null)
          {
              return NotFound();
          }
            return Ok(result);
        }

        // GET: api/Publishers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Publisher>> GetPublisher(int id)
        {
          if (_context.GetAll() == null)
          {
              return NotFound();
          }
            var publisher = await _context.GetById(id);
            if (publisher == null)
            {
                return NotFound();
            }

            return publisher;
        }

        // PUT: api/Publishers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPublisher(int id, Publisher publisher)
        {
            if (id != publisher.Pub_id)
            {
                return BadRequest();
            }

            try
            {
                await _context.Update(publisher);
            }
            catch (DbUpdateConcurrencyException)
            {

            }

            return NoContent();
        }

        // POST: api/Publishers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Publisher>> PostPublisher(Publisher publisher)
        {
          if (_context.GetAll() == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Publisher'  is null.");
          }
            await _context.Add(publisher);

            return CreatedAtAction("GetPublisher", new { id = publisher.Pub_id }, publisher);
        }

        // DELETE: api/Publishers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePublisher(int id)
        {
            if (_context.GetAll() == null)
            {
                return NotFound();
            }
            var publisher = await _context.GetById(id);
            if (publisher == null)
            {
                return NotFound();
            }
            // can xu ly khoa ngoai
            await _context.Delete(id);

            return NoContent();
        }

        
    }
}
