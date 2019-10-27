using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScaleCoreAPI.Models;

namespace ScaleCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhieucansController : ControllerBase
    {
        private readonly SCALES_WITH_ALPR_DBContext _context;

        public PhieucansController(SCALES_WITH_ALPR_DBContext context)
        {
            _context = context;
        }

        // GET: api/Phieucans
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Phieucan>>> GetPhieucan()
        {
            return await _context.Phieucan.ToListAsync();
        }

        // GET: api/Phieucans/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Phieucan>> GetPhieucan(string id)
        {
            var phieucan = await _context.Phieucan.FindAsync(id);

            if (phieucan == null)
            {
                return NotFound();
            }

            return phieucan;
        }


        // GET: api/Phieucans/startdate/enddate
        [HttpGet("{startDate}/{endDate}")]
        public async Task<ActionResult<IEnumerable<Phieucan>>> GetPhieucanByDate(DateTime startdate, DateTime endDate)
        {
            return await _context.Phieucan
                .FromSqlRaw("select * from PhieuCan")
                .Where(p => p.NgayCanLan1 >= startdate && p.NgayCanLan1 <= endDate)
                .OrderByDescending(p => p.MaPhieu)
                .ToListAsync();            
        }

        // PUT: api/Phieucans/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPhieucan(string id, Phieucan phieucan)
        {
            if (id != phieucan.Id)
            {
                return BadRequest();
            }

            _context.Entry(phieucan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PhieucanExists(id))
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

        // POST: api/Phieucans
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Phieucan>> PostPhieucan(Phieucan phieucan)
        {
            _context.Phieucan.Add(phieucan);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PhieucanExists(phieucan.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPhieucan", new { id = phieucan.Id }, phieucan);
        }

        // DELETE: api/Phieucans/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Phieucan>> DeletePhieucan(string id)
        {
            var phieucan = await _context.Phieucan.FindAsync(id);
            if (phieucan == null)
            {
                return NotFound();
            }

            _context.Phieucan.Remove(phieucan);
            await _context.SaveChangesAsync();

            return phieucan;
        }

        private bool PhieucanExists(string id)
        {
            return _context.Phieucan.Any(e => e.Id == id);
        }
    }
}
