using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IrisCore.Models;

namespace IrisCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SitesController : ControllerBase
    {
        private readonly IrisDbContext _context;

        public SitesController(IrisDbContext context)
        {
            _context = context;
        }

        // GET: api/TblSites
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblSite>>> GetTblSite()
        {
            return await _context.TblSite.ToListAsync();
        }

        // GET: api/TblSites/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblSite>> GetTblSite(int id)
        {
            var tblSite = await _context.TblSite.FindAsync(id);

            if (tblSite == null)
            {
                return NotFound();
            }

            return tblSite;
        }

        // PUT: api/TblSites/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblSite(int id, TblSite tblSite)
        {
            if (id != tblSite.SiteId)
            {
                return BadRequest();
            }

            _context.Entry(tblSite).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblSiteExists(id))
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

        // POST: api/TblSites
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<TblSite>> PostTblSite(TblSite tblSite)
        {
            _context.TblSite.Add(tblSite);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblSite", new { id = tblSite.SiteId }, tblSite);
        }

        // DELETE: api/TblSites/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblSite>> DeleteTblSite(int id)
        {
            var tblSite = await _context.TblSite.FindAsync(id);
            if (tblSite == null)
            {
                return NotFound();
            }

            _context.TblSite.Remove(tblSite);
            await _context.SaveChangesAsync();

            return tblSite;
        }

        private bool TblSiteExists(int id)
        {
            return _context.TblSite.Any(e => e.SiteId == id);
        }
    }
}
