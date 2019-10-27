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
    public class XesController : ControllerBase
    {
        private readonly SCALES_WITH_ALPR_DBContext _context;

        public XesController(SCALES_WITH_ALPR_DBContext context)
        {
            _context = context;
        }

        // GET: api/Xes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Xe>>> GetXe()
        {
            return await _context.Xe.ToListAsync();
        }

        // GET: api/Xes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Xe>> GetXe(string id)
        {
            var xe = await _context.Xe.FindAsync(id);

            if (xe == null)
            {
                return NotFound();
            }

            return xe;
        }

        // PUT: api/Xes/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutXe(string id, Xe xe)
        {
            if (id != xe.MaXe)
            {
                return BadRequest();
            }

            _context.Entry(xe).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!XeExists(id))
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

        // POST: api/Xes
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Xe>> PostXe(Xe xe)
        {
            _context.Xe.Add(xe);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (XeExists(xe.MaXe))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetXe", new { id = xe.MaXe }, xe);
        }

        // DELETE: api/Xes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Xe>> DeleteXe(string id)
        {
            var xe = await _context.Xe.FindAsync(id);
            if (xe == null)
            {
                return NotFound();
            }

            _context.Xe.Remove(xe);
            await _context.SaveChangesAsync();

            return xe;
        }

        private bool XeExists(string id)
        {
            return _context.Xe.Any(e => e.MaXe == id);
        }
    }
}
