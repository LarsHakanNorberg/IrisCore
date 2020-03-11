using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IrisCore.Models
{
    public class tblSite
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSite()
        {
            /* tblAccountKeyRoleCompanySiteRelation = new HashSet<tblAccountKeyRoleCompanySiteRelation>();
            tblCompanySiteRelation = new HashSet<tblCompanySiteRelation>();
            tblPosition = new HashSet<tblPosition>();
            tblMyList = new HashSet<tblMyList>();
            tblSiteMaster = new HashSet<tblSiteMaster>();
            tblSubscription = new HashSet<tblSubscription>(); */
        }

        [Key]
        public int SiteID { get; set; }

        [StringLength(200)]
        public string SiteName { get; set; }

        public int? CountryID { get; set; }

        public int? TimeZoneID { get; set; }

        [StringLength(150)]
        public string VisitingAddress { get; set; }

        [StringLength(50)]
        public string VisitingAddressPostalCode { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string State { get; set; }

        [StringLength(150)]
        public string AdditionalAddress1 { get; set; }

        [StringLength(150)]
        public string AdditionalAddress2 { get; set; }

        [StringLength(50)]
        public string PostalAddress { get; set; }

        [StringLength(50)]
        public string PostalAddressPostalCode { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(100)]
        public string Mobile { get; set; }

        [StringLength(100)]
        public string VideoConferenceNo { get; set; }

        [StringLength(100)]
        public string NoToVideoConferenceRoom { get; set; }

        [StringLength(50)]
        public string VideoConferenceIPAddress { get; set; }

        [StringLength(120)]
        public string SiteContactEmail { get; set; }

        public int AddressFormatID { get; set; }

        public DateTime? CreatedDateTime { get; set; }

        public int? CreatedByAccountID { get; set; }

        public DateTime? LastUpdatedDateTime { get; set; }

        public int? LastUpdatedByAccountID { get; set; }

        [StringLength(3)]
        public string SiteCityPrefix { get; set; }

        [StringLength(4)]
        public string SiteCityNumber { get; set; }

        [StringLength(10)]
        public string PhoneAreaCode { get; set; }

        [StringLength(10)]
        public string VisitingAddressStreetNo { get; set; }

        [StringLength(25)]
        public string Longitude { get; set; }

        [StringLength(25)]
        public string Latitude { get; set; }

        [StringLength(10)]
        public string PostalAddressStreetNo { get; set; }

        public int? VideoConferenceAccountID { get; set; }

        public int? SiteNoteStatus { get; set; }

        public string SiteNote { get; set; }

        [StringLength(50)]
        public string SquareMeters { get; set; }

        [StringLength(50)]
        public string SquareFeet { get; set; }

        public int SiteStatusID { get; set; }
        /*
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAccountKeyRoleCompanySiteRelation> tblAccountKeyRoleCompanySiteRelation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCompanySiteRelation> tblCompanySiteRelation { get; set; }

        public virtual tblCountry tblCountry { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPosition> tblPosition { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMyList> tblMyList { get; set; }

        public virtual tblSiteStatus tblSiteStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSiteMaster> tblSiteMaster { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSubscription> tblSubscription { get; set; } */
    }
}
