using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IrisCore.Models
{
    [Table("tblSite")]
    public class tblSite
    {
        public int SiteId { get; set; }
        public string SiteName { get; set; }
    }
}
