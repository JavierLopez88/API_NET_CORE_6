using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Backend.DataAcces;
using Backend.Models;
using Index = Backend.Models.Index;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndicesController : ControllerBase
    {
        private readonly UniversityDBContext _context;

        public IndicesController(UniversityDBContext context)
        {
            _context = context;
        }

        // GET: api/Indices
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Index>>> GetIndexes()
        {
            return await _context.Indexes.ToListAsync();
        }

        // GET: api/Indices/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Index>> GetIndex(int id)
        {
            var index = await _context.Indexes.FindAsync(id);

            if (index == null)
            {
                return NotFound();
            }

            return index;
        }

        // PUT: api/Indices/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIndex(int id, Index index)
        {
            if (id != index.Id)
            {
                return BadRequest();
            }

            _context.Entry(index).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IndexExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Indices
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Index>> PostIndex(Index index)
        {
            _context.Indexes.Add(index);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIndex", new { id = index.Id }, index);
        }

        // DELETE: api/Indices/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIndex(int id)
        {
            var index = await _context.Indexes.FindAsync(id);
            if (index == null)
            {
                return NotFound();
            }

            _context.Indexes.Remove(index);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool IndexExists(int id)
        {
            return _context.Indexes.Any(e => e.Id == id);
        }
    }
}
