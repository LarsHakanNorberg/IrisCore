using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IrisCore.Models
{
    [Table("tblLegalEntity")]
    public class tblLegalEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblLegalEntity()
        {
            tblCompany = new HashSet<tblCompany>();
        }

        [Key]
        public int LegalEntityID { get; set; }

        [Required]
        [StringLength(255)]
        public string LegalEntityName { get; set; }

        public int? CountryID { get; set; }

        public int? LegalSiteID { get; set; }

        [StringLength(255)]
        public string RegistrationNumber { get; set; }

        public DateTime? CreatedDateTime { get; set; }

        public int? CreatedByAccountID { get; set; }

        public DateTime? LastUpdatedDateTime { get; set; }

        public int? LastUpdatedByAccountID { get; set; }

        [StringLength(50)]
        public string LegalEntityCode { get; set; }

        public bool IsValid { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCompany> tblCompany { get; set; }

        public virtual tblCountry tblCountry { get; set; }

        public virtual tblLegalSite tblLegalSite { get; set; }
    }
}
