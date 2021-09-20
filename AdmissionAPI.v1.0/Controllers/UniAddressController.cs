using AdmissionAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionAPI.v1._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniAddressController : ControllerBase
    {
        private readonly AdmissionContext _context;

        public UniAddressController(AdmissionContext context)
        {
            _context = context;
        }

        // GET: api/UniAddress
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UniAddress>>> GetUniAddress()
        {
            return await _context.UniAddress.ToListAsync();
        }

        // GET: api/UniAddress/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UniAddress>> GetUniAddress(int id)
        {
            var uniAddress = await _context.UniAddress.FindAsync(id);

            if (uniAddress == null)
            {
                return NotFound();
            }

            return uniAddress;
        }

        // PUT: api/UniAddress/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUniAddress(int id, UniAddress uniAddress)
        {
            if (id != uniAddress.Id)
            {
                return BadRequest();
            }

            _context.Entry(uniAddress).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UniAddressExists(id))
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

        // POST: api/UniAddress
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UniAddress>> PostUniAddress(UniAddress uniAddress)
        {
            _context.UniAddress.Add(uniAddress);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUniAddress", new { id = uniAddress.Id }, uniAddress);
        }

        // DELETE: api/UniAddress/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUniAddress(int id)
        {
            var uniAddress = await _context.UniAddress.FindAsync(id);
            if (uniAddress == null)
            {
                return NotFound();
            }

            _context.UniAddress.Remove(uniAddress);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UniAddressExists(int id)
        {
            return _context.UniAddress.Any(e => e.Id == id);
        }
    }
}
