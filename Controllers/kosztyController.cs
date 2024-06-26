﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using MyApplication.Data;
using MyApplication.Models;

namespace MyApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class kosztyController : Controller
    {
        private readonly DataContext _context;

        public kosztyController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Koszty
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Koszt>>> GetKoszty()
        {
            return await _context.Koszty.ToListAsync();
        }

        // GET: api/RodzajKosztu
        [HttpGet("{RodzajKosztu}")]
        public async Task<ActionResult<IEnumerable<Koszt>>> GetKosztyDanegoRodzaju(string RodzajKosztu)
        {
            return await _context.Koszty.Where(x => x.RodzajKosztu == RodzajKosztu).ToListAsync();
        }

        // POST: api/Koszty
        [HttpPost]
        public async Task<ActionResult<Koszt>> PostKoszty(Koszt koszty)
        {
            _context.Koszty.Add(koszty);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetKoszty", new { id = koszty.Id }, koszty);
        }

        private bool KosztyExists(long id)
        {
            return _context.Koszty.Any(e => e.Id == id);
        }

        // PUT: api/Koszty/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKoszty(int id, Koszt koszty)
        {
            if (id != koszty.Id)
            {
                return BadRequest();
            }

            _context.Entry(koszty).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KosztyExists(id))
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

        // DELETE: api/Koszty/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKoszty(int id)
        {
            var koszty = await _context.Koszty.FindAsync(id);
            if (koszty == null)
            {
                return NotFound();
            }

            _context.Koszty.Remove(koszty);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
