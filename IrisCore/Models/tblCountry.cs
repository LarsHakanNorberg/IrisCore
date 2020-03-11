using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IrisCore.Models
{
    public class tblCountry
    {
        [Key]
        public int CountryID { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
    }
}
