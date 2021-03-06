﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IrisCore.Models;
using IrisCore.Services;

namespace IrisCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SitesController : ControllerBase
    {
        private readonly IrisDbContext _context;
        private readonly SqlSiteService _sqlSiteService;

        public SitesController(IrisDbContext context, SqlSiteService sqlSiteService)
        {
            _context = context;
            _sqlSiteService = sqlSiteService;
        }

        // GET: api/TblSites
        [HttpGet]
        public async Task<ActionResult<IEnumerable<vWaSite>>> GetTblSite() 
        {
            //return await _context.TblSite.ToListAsync();
            return await _context.vWaSite.ToListAsync();
            
        }

        // GET: api/TblSites/5
        [HttpGet("{id}")]
        public async Task<ActionResult<tblSite>> GetTblSite(int id)
        {
            var tblSite = await _context.tblSite.FindAsync(id);

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
        public async Task<IActionResult> PutTblSite(int id, tblSite tblSite)
        {
            if (id != tblSite.SiteID)
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
        public async Task<ActionResult<tblSite>> PostTblSite(tblSite tblSite)
        {
            _context.tblSite.Add(tblSite);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblSite", new { id = tblSite.SiteID }, tblSite);
        }

        // DELETE: api/TblSites/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<tblSite>> DeleteTblSite(int id)
        {
            var tblSite = await _context.tblSite.FindAsync(id);
            if (tblSite == null)
            {
                return NotFound();
            }

            _context.tblSite.Remove(tblSite);
            await _context.SaveChangesAsync();

            return tblSite;
        }

        private bool TblSiteExists(int id)
        {
            return _context.tblSite.Any(e => e.SiteID == id);
        }
    }
}
