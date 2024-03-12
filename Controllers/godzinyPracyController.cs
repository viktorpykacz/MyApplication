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
    public class GodzinyPracyController : Controller
    {
        private readonly DataContext _context;

        public GodzinyPracyController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Godziny
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GodzinyPracy>>> GetGodziny()
        {
            return await _context.RaportGodzinPracy.ToListAsync();
        }

        //GET: api/Godziny/NazwaProjektu
        [HttpGet("{NazwaProjektu}")]
        public async Task<ActionResult<IEnumerable<GodzinyPracy>>> GetGodzinyZProjektu(string NazwaProjektu)
        {
            return await _context.RaportGodzinPracy.Where(x => x.NazwaProjektu == NazwaProjektu).ToListAsync();
        }

        // POST: api/Godziny
        [HttpPost]
        public async Task<ActionResult<GodzinyPracy>> PostGodziny(GodzinyPracy godziny)
        {
            _context.RaportGodzinPracy.Add(godziny);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGodziny", new { id = godziny.Id }, godziny);
        }

        private bool GodzinyExists(long id)
        {
            return _context.RaportGodzinPracy.Any(e => e.Id == id);
        }

        // PUT: api/Godziny
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGodziny(int id, GodzinyPracy godziny)
        {
            if (id != godziny.Id)
            {
                return BadRequest();
            }

            _context.Entry(godziny).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GodzinyExists(id))
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

        // DELETE: api/Godziny/1
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGodziny(int id)
        {
            var godziny = await _context.RaportGodzinPracy.FindAsync(id);
            if (godziny == null)
            {
                return NotFound();
            }

            _context.RaportGodzinPracy.Remove(godziny);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
