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
    public class ZestawienieMiesieczneFirmyController : Controller
    {
        private readonly DataContext _context;

        public ZestawienieMiesieczneFirmyController(DataContext context)
        {
            _context = context;
        }

        // GET: api/ZestawienieMiesieczne
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ZestawienieMiesieczneFirmy>>> GetZestawienieMiesieczne()
        {
            return await _context.ZestawienieMiesieczneFirmy.ToListAsync();
        }


        //GET: api/ZestawienieMiesieczne/Rok/Miesiac
        [HttpGet("{Rok}/{Miesiac}")]
        public async Task<ActionResult<IEnumerable<ZestawienieMiesieczneFirmy>>> GetZestawienieMiesieczneZRokuZMiesiaca(int Rok, int Miesiac)
        {
            return await _context.ZestawienieMiesieczneFirmy
                .Where(x => x.Rok == Rok)
                .Where(x => x.Miesiac == Miesiac)
                .ToListAsync();
        }

        // POST: api/ZestawienieMiesieczne
        [HttpPost]
        public async Task<ActionResult<ZestawienieMiesieczneFirmy>> PostZestawienieMiesieczne(ZestawienieMiesieczneFirmy zestawienieMiesieczne)
        {
            _context.ZestawienieMiesieczneFirmy.Add(zestawienieMiesieczne);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetZestawienieMiesieczne", new { id = zestawienieMiesieczne.Id }, zestawienieMiesieczne);
        }

        private bool ZestawienieMiesieczneExists(long id)
        {
            return _context.ZestawienieMiesieczneFirmy.Any(e => e.Id == id);
        }

        // PUT: api/ZestawienieMiesieczne
        [HttpPut("{id}")]
        public async Task<IActionResult> PutZestawienieMiesieczne(int id, ZestawienieMiesieczneFirmy zestawienieMiesieczne)
        {
            if (id != zestawienieMiesieczne.Id)
            {
                return BadRequest();
            }

            _context.Entry(zestawienieMiesieczne).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ZestawienieMiesieczneExists(id))
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

        // DELETE: api/ZestawienieMiesieczne/1
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteZestawienieMiesieczne(int id)
        {
            var ZestawienieMiesieczne = await _context.ZestawienieMiesieczneFirmy.FindAsync(id);
            if (ZestawienieMiesieczne == null)
            {
                return NotFound();
            }

            _context.ZestawienieMiesieczneFirmy.Remove(ZestawienieMiesieczne);
            await _context.SaveChangesAsync();

            return NoContent();
        }



    }
}