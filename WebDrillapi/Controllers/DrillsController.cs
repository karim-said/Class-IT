using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebDrillapi.DData;
using WebDrillapi.Models;

namespace WebDrillapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrillsController : ControllerBase
    {
        private readonly DrillContext _context;

        public DrillsController(DrillContext context)
        {
            _context = context;
        }

        // GET: api/Drills
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Drill>>> GetDrills()
        {
          if (_context.Drills == null)
          {
              return NotFound();
          }
            return await _context.Drills.ToListAsync();
        }

        // GET: api/Drills/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Drill>> GetDrill(int id)
        {
          if (_context.Drills == null)
          {
              return NotFound();
          }
            var drill = await _context.Drills.FindAsync(id);

            if (drill == null)
            {
                return NotFound();
            }

            return drill;
        }

        // PUT: api/Drills/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDrill(int id, Drill drill)
        {
            if (id != drill.Id)
            {
                return BadRequest();
            }

            _context.Entry(drill).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DrillExists(id))
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

        // POST: api/Drills
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Drill>> PostDrill(Drill drill)
        {
          if (_context.Drills == null)
          {
              return Problem("Entity set 'DrillContext.Drills'  is null.");
          }
            _context.Drills.Add(drill);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDrill", new { id = drill.Id }, drill);
        }

        // DELETE: api/Drills/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDrill(int id)
        {
            if (_context.Drills == null)
            {
                return NotFound();
            }
            var drill = await _context.Drills.FindAsync(id);
            if (drill == null)
            {
                return NotFound();
            }

            _context.Drills.Remove(drill);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DrillExists(int id)
        {
            return (_context.Drills?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
