using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WEB_API_IAS.DbContext;
using WEB_API_IAS.Models;

namespace WEB_API_IAS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutomovilesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AutomovilesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Automoviles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Automoviles>>> GetAutomoviles()
        {
            return await _context.Automoviles.ToListAsync();
        }

        // GET: api/Automoviles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Automoviles>> GetAutomoviles(int id)
        {
            var automoviles = await _context.Automoviles.FindAsync(id);

            if (automoviles == null)
            {
                return NotFound();
            }

            return automoviles;
        }

        // PUT: api/Automoviles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAutomoviles(int id, Automoviles automoviles)
        {
            if (id != automoviles.Id)
            {
                return BadRequest();
            }

            _context.Entry(automoviles).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AutomovilesExists(id))
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

        // POST: api/Automoviles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Automoviles>> PostAutomoviles(Automoviles automoviles)
        {
            _context.Automoviles.Add(automoviles);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAutomoviles", new { id = automoviles.Id }, automoviles);
        }

        // DELETE: api/Automoviles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAutomoviles(int id)
        {
            var automoviles = await _context.Automoviles.FindAsync(id);
            if (automoviles == null)
            {
                return NotFound();
            }

            _context.Automoviles.Remove(automoviles);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AutomovilesExists(int id)
        {
            return _context.Automoviles.Any(e => e.Id == id);
        }
    }
}
