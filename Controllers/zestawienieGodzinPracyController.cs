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
    public class ZestawienieGodzinPracyController : Controller
    {
        private readonly DataContext _context;

        public ZestawienieGodzinPracyController(DataContext context)
        {
            _context = context;
        }

        // GET: api/ZestawienieGodzin
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ZestawienieGodzinPracy>>> GetZestawienieGodzin()
        {
            return await _context.ZestawienieGodzinPracy.ToListAsync();
        }

        //GET: api/ZestawienieGodzin/NazwaProjektu
        [HttpGet("{NazwaProjektu}")]
        public async Task<ActionResult<IEnumerable<ZestawienieGodzinPracy>>> GetZestawienieGodzinZProjektu(string NazwaProjektu)
        {
            return await _context.ZestawienieGodzinPracy.Where(x => x.NazwaProjektu == NazwaProjektu).ToListAsync();
        }

        //GET: api/ZestawienieGodzin/Rok/Miesiac
        [HttpGet("{NazwaProjektu}/{Rok}/{Miesiac}")]
        public async Task<ActionResult<IEnumerable<ZestawienieGodzinPracy>>> GetZestawienieGodzinZProjektuZRokuZMiesiaca(string NazwaProjektu, int Rok, int Miesiac)
        {
            return await _context.ZestawienieGodzinPracy
                .Where(x => x.NazwaProjektu == NazwaProjektu)
                .Where(x => x.Rok == Rok)
                .Where(x => x.Miesiac == Miesiac)
                .ToListAsync();
        }

        // POST: api/ZestawienieGodzin
        [HttpPost]
        public async Task<ActionResult<ZestawienieGodzinPracy>> PostZestawienieGodzin(ZestawienieGodzinPracy zestawienieGodzin)
        {
            _context.ZestawienieGodzinPracy.Add(zestawienieGodzin);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetZestawienieGodzin", new { id = zestawienieGodzin.Id }, zestawienieGodzin);
        }

        private bool ZestawienieGodzinExists(long id)
        {
            return _context.ZestawienieGodzinPracy.Any(e => e.Id == id);
        }

        // PUT: api/ZestawienieGodzin
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGodziny(int id, ZestawienieGodzinPracy zestawienieGodzin)
        {
            if (id != zestawienieGodzin.Id)
            {
                return BadRequest();
            }

            _context.Entry(zestawienieGodzin).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ZestawienieGodzinExists(id))
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

        // DELETE: api/ZestawienieGodzin/1
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteZestawienieGodzin(int id)
        {
            var ZestawienieGodzin = await _context.ZestawienieGodzinPracy.FindAsync(id);
            if (ZestawienieGodzin == null)
            {
                return NotFound();
            }

            _context.ZestawienieGodzinPracy.Remove(ZestawienieGodzin);
            await _context.SaveChangesAsync();

            return NoContent();
        }




    }

}
