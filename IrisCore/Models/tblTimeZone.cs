using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IrisCore.Models
{
    public class tblTimeZone
    {
        [Key]
        public int TimeZoneID { get; set; }
        public string TimeZoneCode { get; set; }
    }
}
