using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IrisCore.Models
{
    [Table("vWaSites")]
    public class vWaSite
    {
        public int SiteID { get; set; }
        public string SiteCode { get; set; }
        public string Site { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string CountryCode { get; set; }
        public string Country { get; set; }
        public string Currency { get; set; }
        [NotMapped]
        public bool Active { get; set; }
        [NotMapped]
        public string TimeZone { get; set; }
    }
}
