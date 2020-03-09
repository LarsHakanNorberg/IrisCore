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
        public IrisDbService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }
        public IWebHostEnvironment WebHostEnvironment { get; }
        public IEnumerable<vWaSite> GetWaSites(IrisDbContext context)
        {
            return context.vWaSite.ToList(); // Kan den vara async?
        }
        public List<Site> GetAllSites()
        {
            using (IrisContext irisDbContext = new IrisContext())
            {
                var siteList = (
                    from st in irisDbContext.tblSite
                    join co in irisDbContext.tblCountry on st.CountryID equals co.CountryID into country
                    from tcountry in country.DefaultIfEmpty()
                    join tz in irisDbContext.tblTimeZone on st.TimeZoneID equals tz.TimeZoneID into tzone
                    from ttzone in tzone.DefaultIfEmpty()
                    select new Site()
                    {
                        SiteID = st.SiteID,
                        IsActive = st.SiteStatusID == 1,
                        AdditionalAddress1 = st.AdditionalAddress1,
                        AdditionalAddress2 = st.AdditionalAddress2,
                        City = st.City,
                        Latitude = st.Latitude,
                        Longitude = st.Longitude,
                        PhoneAreaCode = st.PhoneAreaCode,
                        Country = tcountry.CountryCode,
                        SiteName = st.SiteName,
                        SquareFeet = st.SquareFeet,
                        SquareMeters = st.SquareMeters,
                        State = st.State,
                        TimeZone = ttzone.TimeZoneCode,
                        VisitingAddress = st.VisitingAddress,
                        VisitingAddressPostalcode = st.VisitingAddressPostalCode,
                        VisitingAddressStreetNo = st.VisitingAddressStreetNo
                    }
                ).ToList();
                foreach (var s in siteList) /// workaround LN 2017-11-21
                {
                    s.SiteCode = s.Country + s.SiteID.ToString("D4");
                }
                return siteList;
            }
        }
    }
}
 