using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IrisCore.Models;
using IrisCore.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IrisCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly IrisDbContext _irisDbContext;

        public CompaniesController(IrisDbContext irisDbContext, IrisDbService sqlSiteService)
        {
            _irisDbContext = irisDbContext;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Company>>> GetCompanies() // Hur fan blir den async?
        {
            return (
                from tc in _irisDbContext.tblCompany
                join tle in _irisDbContext.tblLegalEntity on tc.LegalEntityID equals tle.LegalEntityID into legal
                from tlegal in legal.DefaultIfEmpty()
                join tco in _irisDbContext.tblCountry on tlegal.CountryID equals tco.CountryID
                select new Company()
                {
                    CompanyID = tc.CompanyID,
                    CompanyCode = tc.CompanyCode,
                    CompanyDisplayName = tc.CompanyDisplayName,
                    CompanyTypeID = tc.CompanyTypeID,
                    IsActive = tc.CompanyTypeID == 8 ? false : true,
                    LegalCountry = tco.CountryCode,
                    LegalEntityCode = tlegal.LegalEntityCode,
                    LegalEntityName = tlegal.LegalEntityName,
                    UnitID = tc.UnitID
                }).ToList();
        }
    }
}