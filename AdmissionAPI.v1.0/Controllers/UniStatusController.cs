using AdmissionAPI.Models;
using AdmissionAPI.v1._0.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionAPI.v1._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniStatusController : ControllerBase
    {


        private readonly AdmissionContext _context;
        private readonly IMapper mapper;

        public UniStatusController(IMapper Imapper, AdmissionContext context)
        {
            _context = context;
            mapper = Imapper;
        }

        // GET: api/UniStatus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UniStatus>>> GetUniStatus()
        {
            return await _context.UniStatus.ToListAsync();
        }

        // GET: api/UniStatus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UniStatus>> GetUniStatus(int id)
        {
            var uniStatus = await _context.UniStatus.FindAsync(id);

            if (uniStatus == null)
            {
                return NotFound();
            }

            return uniStatus;
        }

        // PUT: api/UniStatus/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUniStatus(int id, UniStatus uniStatus)
        {
            if (id != uniStatus.Id)
            {
                return BadRequest();
            }

            _context.Entry(uniStatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UniStatusExists(id))
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

        // POST: api/UniStatus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UniStatus>> PostUniStatus(UniStatusView uniStatusView)
        {
            var uniStatus = mapper.Map<UniStatus>(uniStatusView);

            _context.UniStatus.Add(uniStatus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUniStatus", new { id = uniStatus.Id }, uniStatus);
        }

        // DELETE: api/UniStatus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUniStatus(int id)
        {
            var uniStatus = await _context.UniStatus.FindAsync(id);
            if (uniStatus == null)
            {
                return NotFound();
            }

            _context.UniStatus.Remove(uniStatus);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UniStatusExists(int id)
        {
            return _context.UniStatus.Any(e => e.Id == id);
        }
    }
}
