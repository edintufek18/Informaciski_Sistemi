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

namespace WowRoads.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiKeyAuth]
    public class PlaceApiController : ControllerBase
    {
        private readonly DataContext _context;

        public PlaceApiController(DataContext context)
        {
            _context = context;
        }

        // GET: api/PlaceApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Place>>> GetPlace()
        {
            return await _context.Place.ToListAsync();
        }

        // GET: api/PlaceApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Place>> GetPlace(int id)
        {
            var place = await _context.Place.FindAsync(id);

            if (place == null)
            {
                return NotFound();
            }

            return place;
        }

        // PUT: api/PlaceApi/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlace(int id, Place place)
        {
            if (id != place.PlaceID)
            {
                return BadRequest();
            }

            _context.Entry(place).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlaceExists(id))
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

        // POST: api/PlaceApi
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Place>> PostPlace(Place place)
        {
            _context.Place.Add(place);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPlace", new { id = place.PlaceID }, place);
        }

        // DELETE: api/PlaceApi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlace(int id)
        {
            var place = await _context.Place.FindAsync(id);
            if (place == null)
            {
                return NotFound();
            }

            _context.Place.Remove(place);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PlaceExists(int id)
        {
            return _context.Place.Any(e => e.PlaceID == id);
        }
    }
}
