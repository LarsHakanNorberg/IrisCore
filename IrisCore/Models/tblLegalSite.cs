using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IrisCore.Models
{
    [Table("tblLegalSite")]
    public class tblLegalSite
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblLegalSite()
        {
            tblLegalEntity = new HashSet<tblLegalEntity>();
        }

        [Key]
        public int LegalSiteID { get; set; }

        [StringLength(500)]
        public string RegistrationAddress { get; set; }

        [StringLength(50)]
        public string RegistrationPostalCode { get; set; }

        [StringLength(50)]
        public string RegistrationCity { get; set; }

        [StringLength(50)]
        public string RegistrationState { get; set; }

        [StringLength(500)]
        public string RegistrationAddressOriginal { get; set; }

        public DateTime? CreatedDateTime { get; set; }

        public int? CreatedByAccountID { get; set; }

        public DateTime? LastUpdatedDateTime { get; set; }

        public int? LastUpdatedByAccountID { get; set; }

        // public virtual tblAccount tblAccount { get; set; }

        // public virtual tblAccount tblAccount1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblLegalEntity> tblLegalEntity { get; set; }
    }
}
