using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DVDAPI.data;

namespace DVDAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MouseController : ControllerBase
    {
        private readonly MouseContext _context;

        public MouseController(MouseContext context)
        {
            _context = context;
        }

        // GET: api/DVD
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mouse_Is.Mouse>>> GetDVDs()
        {
            if (_context.Mouse == null)
            {
                return NotFound();
            }
            return await _context.Mouse.ToListAsync();
        }

        // GET: api/DVD/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Mouse_Is.Mouse>> GetDVD(int id)
        {
            if (_context.Mouse == null)
            {
                return NotFound();
            }
            var dVD = await _context.Mouse.FindAsync(id);

            if (dVD == null)
            {
                return NotFound();
            }

            return dVD;
        }

        // PUT: api/DVD/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDVD(int id, Mouse_Is.Mouse dVD)
        {
            if (id != dVD.Id)
            {
                return BadRequest();
            }

            _context.Entry(dVD).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DVDExists(id))
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

        // POST: api/DVD
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Mouse_Is.Mouse>> PostDVD(Mouse_Is.Mouse dVD)
        {
            if (_context.Mouse == null)
            {
                return Problem("Entity set 'DVDContext.DVDs'  is null.");
            }
            _context.Mouse.Add(dVD);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDVD", new { id = dVD.Id }, dVD);
        }

        // DELETE: api/DVD/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDVD(int id)
        {
            if (_context.Mouse == null)
            {
                return NotFound();
            }
            var dVD = await _context.Mouse.FindAsync(id);
            if (dVD == null)
            {
                return NotFound();
            }

            _context.Mouse.Remove(dVD);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DVDExists(int id)
        {
            return (_context.Mouse?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
