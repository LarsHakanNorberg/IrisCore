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
 