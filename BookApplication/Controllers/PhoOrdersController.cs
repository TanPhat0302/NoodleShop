using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookApplication.Data;
using BookApplication.Models;

namespace BookApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoOrdersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PhoOrdersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/PhoOrders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PhoOrder>>> GetPhoOrders()
        {
          if (_context.PhoOrders == null)
          {
              return NotFound();
          }
            return await _context.PhoOrders.ToListAsync();
        }

        // GET: api/PhoOrders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PhoOrder>> GetPhoOrder(int id)
        {
          if (_context.PhoOrders == null)
          {
              return NotFound();
          }
            var phoOrder = await _context.PhoOrders.FindAsync(id);

            if (phoOrder == null)
            {
                return NotFound();
            }

            return phoOrder;
        }

        // PUT: api/PhoOrders/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPhoOrder(int id, PhoOrder phoOrder)
        {
            if (id != phoOrder.Id)
            {
                return BadRequest();
            }

            _context.Entry(phoOrder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PhoOrderExists(id))
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

        // POST: api/PhoOrders
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PhoOrder>> PostPhoOrder(PhoOrder phoOrder)
        {
          if (_context.PhoOrders == null)
          {
              return Problem("Entity set 'ApplicationDbContext.PhoOrders'  is null.");
          }
            _context.PhoOrders.Add(phoOrder);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPhoOrder", new { id = phoOrder.Id }, phoOrder);
        }

        // DELETE: api/PhoOrders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePhoOrder(int id)
        {
            if (_context.PhoOrders == null)
            {
                return NotFound();
            }
            var phoOrder = await _context.PhoOrders.FindAsync(id);
            if (phoOrder == null)
            {
                return NotFound();
            }

            _context.PhoOrders.Remove(phoOrder);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PhoOrderExists(int id)
        {
            return (_context.PhoOrders?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
