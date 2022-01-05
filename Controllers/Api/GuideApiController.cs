using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WowRoads.Data;
using WowRoads.Models;
using WowRoads.Filters;

namespace IS.Controllers_Api
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiKeyAuth]
    public class GuideApiController : ControllerBase
    {
        private readonly DataContext _context;

        public GuideApiController(DataContext context)
        {
            _context = context;
        }

        // GET: api/GuideApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Guide>>> GetGuide()
        {
            return await _context.Guide.ToListAsync();
        }

        // GET: api/GuideApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Guide>> GetGuide(int id)
        {
            var guide = await _context.Guide.FindAsync(id);

            if (guide == null)
            {
                return NotFound();
            }

            return guide;
        }

        // PUT: api/GuideApi/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGuide(int id, Guide guide)
        {
            if (id != guide.GuideID)
            {
                return BadRequest();
            }

            _context.Entry(guide).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GuideExists(id))
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

        // POST: api/GuideApi
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Guide>> PostGuide(Guide guide)
        {
            _context.Guide.Add(guide);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGuide", new { id = guide.GuideID }, guide);
        }

        // DELETE: api/GuideApi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGuide(int id)
        {
            var guide = await _context.Guide.FindAsync(id);
            if (guide == null)
            {
                return NotFound();
            }

            _context.Guide.Remove(guide);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GuideExists(int id)
        {
            return _context.Guide.Any(e => e.GuideID == id);
        }
    }
}
