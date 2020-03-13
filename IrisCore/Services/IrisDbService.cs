using IrisCore.Models;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IrisCore.Services
{
    public class IrisDbService
    {
        public IrisDbService(IrisDbContext irisDbContext)
        {
            _irisDbContext = irisDbContext;
        }
        private IrisDbContext _irisDbContext { get; }
        public IEnumerable<vWaSite> GetWaSites()
        {
            return _irisDbContext.vWaSite.ToList(); // Kan den vara async?
        }
        public IEnumerable<Company> GetAllCompanies()
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
        public List<vWaSite> GetAllSites()
        {
            var siteList = (
                from st in _irisDbContext.tblSite
                join co in _irisDbContext.tblCountry on st.CountryID equals co.CountryID into country
                from tcountry in country.DefaultIfEmpty()
                join tz in _irisDbContext.tblTimeZone on st.TimeZoneID equals tz.TimeZoneID into tzone
                from ttzone in tzone.DefaultIfEmpty()
                select new vWaSite()
                {
                    SiteID = st.SiteID,
                    SiteCode = tcountry.CountryCode + st.SiteID.ToString("D4"),
                    Active = st.SiteStatusID == 1,
                    City = st.City,
                    Country = tcountry.CountryCode,
                    State = st.State,
                    TimeZone = ttzone.TimeZoneCode,
                }
            ).ToList();
            return siteList;
        }
    }
}
 