using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyApplication.Data;
using MyApplication.Models;

namespace MyApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class kontraktyController : Controller
    {
        private readonly DataContext _context;

        public kontraktyController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Kontrakty
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Kontrakt>>> GetKontrakty()
        {
            return await _context.Kontrakty.ToListAsync();
        }

        //GET: api/Kontrakty/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Kontrakt>>> GetKontraktyId(int id)
        {
            return await _context.Kontrakty
                .Where(x => x.Id == id)
                .ToListAsync();
        }

        // POST: api/Kontrakty
        [HttpPost]
        public async Task<ActionResult<Kontrakt>> PostKontrakt(Kontrakt kontrakt)
        {
            _context.Kontrakty.Add(kontrakt);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetKontrakty", new { id = kontrakt.Id }, kontrakt);
        }
        private bool KontraktyExists(long id)
        {
            return _context.Kontrakty.Any(e => e.Id == id);
        }

        // PUT: api/Kontrakt
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKontrakt(int id, Kontrakt kontrakt)
        {
            if (id != kontrakt.Id)
            {
                return BadRequest();
            }

            _context.Entry(kontrakt).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KontraktyExists(id))
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

        // DELETE: api/Kontrakty/1
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKontrakt(int id)
        {
            var kontrakt = await _context.Kontrakty.FindAsync(id);
            if (kontrakt == null)
            {
                return NotFound();
            }

            _context.Kontrakty.Remove(kontrakt);
            await _context.SaveChangesAsync();

            return NoContent();
        }






    }
}
