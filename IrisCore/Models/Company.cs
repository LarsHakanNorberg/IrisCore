using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IrisCore.Models
{
    public class Company
    {
        [Key]
        public int CompanyID { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyDisplayName { get; set; }
        public int CompanyTypeID { get; set; }
        public bool IsActive { get; set; }
        public string LegalCountry { get; set; }
        public string LegalEntityCode { get; set; }
        public string LegalEntityName { get; set; }
        public int? UnitID { get; set; }
    }
}
