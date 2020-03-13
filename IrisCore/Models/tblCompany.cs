using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IrisCore.Models
{
    public class tblCompany
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCompany()
        {
            // tblAccountKeyRoleCompanySiteRelation = new HashSet<tblAccountKeyRoleCompanySiteRelation>();
            // tblBrandCompanyRelation = new HashSet<tblBrandCompanyRelation>();
            // tblCompany1 = new HashSet<tblCompany>();
            // tblCompany11 = new HashSet<tblCompany>();
            // tblCompanyChangeLog = new HashSet<tblCompanyChangeLog>();
            // tblCompanyDomainRelation = new HashSet<tblCompanyDomainRelation>();
            // tblCompanyLegalInfo1 = new HashSet<tblCompanyLegalInfo>();
            // tblCompanyWebsiteRelation = new HashSet<tblCompanyWebsiteRelation>();
            // tblDirectoryMaster = new HashSet<tblDirectoryMaster>();
            // tblLegalCompany = new HashSet<tblLegalCompany>();
            // tblMyList = new HashSet<tblMyList>();
            // tblPosition = new HashSet<tblPosition>();
            // tblSubscription = new HashSet<tblSubscription>();
            // tblUnit1 = new HashSet<tblUnit>();
            // tblCompanySiteRelation = new HashSet<tblCompanySiteRelation>();
        }

        [Key]
        public int CompanyID { get; set; }

        [StringLength(50)]
        public string CompanyCode { get; set; }

        [StringLength(80)]
        public string CompanyDisplayName { get; set; }

        public int? ParentCompanyID { get; set; }

        public int? UnitID { get; set; }

        public int CompanyTypeID { get; set; }

        public int? CompanyDescriptionID { get; set; }

        [StringLength(250)]
        public string ShortDescription { get; set; }

        [StringLength(250)]
        public string Keywords { get; set; }

        public int? IsShowWebExternal { get; set; }

        public int? IsShowWebInternal { get; set; }

        public int? IsShowAccountRequest { get; set; }

        public int? OrderIndex { get; set; }

        [StringLength(200)]
        public string AdminComment { get; set; }

        public int? IsExternalSales { get; set; }

        public int? IsProduction { get; set; }

        public int? IsICPPartner { get; set; }

        public int? BenchmarkingTypeID { get; set; }

        public int? LogoTypeID { get; set; }

        public byte? isNeedDMCheck { get; set; }

        [Column(TypeName = "ntext")]
        public string DMCheckReason { get; set; }

        [Column(TypeName = "ntext")]
        public string DMCheckComment { get; set; }

        public DateTime? CreatedDateTime { get; set; }

        public int? CreatedByAccountID { get; set; }

        public DateTime? LastUpdatedDateTime { get; set; }

        public int? LastUpdatedByAccountID { get; set; }

        public DateTime? ValidStartDate { get; set; }

        public DateTime? InactivationDate { get; set; }

        public int? IsLockPack { get; set; }

        public int? OrganizationalLevelParentCompanyID { get; set; }

        public int? IsValidICP { get; set; }

        [StringLength(250)]
        public string RegisteredOffice { get; set; }

        [StringLength(80)]
        public string LegalCompanyName { get; set; }

        public int? CountryID { get; set; }

        [Column("VAT.n.o.")]
        public int? VAT_n_o_ { get; set; }

        [Column("Reg.date")]
        public DateTime? Reg_date { get; set; }

        public DateTime? AcquisitionDate { get; set; }

        [StringLength(250)]
        public string Comment { get; set; }

        [StringLength(255)]
        public string Seat { get; set; }

        public int? IsLegalEntity { get; set; }

        public int? AccountGroupIdIntranet { get; set; }

        [StringLength(50)]
        public string OldCompanyCode { get; set; }

        public int? ActiveDirectoryID { get; set; }

        public int? LegalEntityID { get; set; }

        public int? ReplacedByCompanyID { get; set; }

        public int? DomainID { get; set; }

        [StringLength(3)]
        public string CurrencyID { get; set; }

        // public virtual tblAccountGroup tblAccountGroup { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        // public virtual ICollection<tblAccountKeyRoleCompanySiteRelation> tblAccountKeyRoleCompanySiteRelation { get; set; }

        // public virtual tblBenchmarkingType tblBenchmarkingType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        // public virtual ICollection<tblBrandCompanyRelation> tblBrandCompanyRelation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        // public virtual ICollection<tblCompany> tblCompany1 { get; set; }

        // public virtual tblCompany tblCompany2 { get; set; }

        // public virtual tblCompanyDescription tblCompanyDescription { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCompany> tblCompany11 { get; set; }

        public virtual tblCompany tblCompany3 { get; set; }

        // public virtual tblCompanyType tblCompanyType { get; set; }

        public virtual tblCountry tblCountry { get; set; }

        // public virtual tblCurrency tblCurrency { get; set; }

        // public virtual tblDomain tblDomain { get; set; }

        public virtual tblLegalEntity tblLegalEntity { get; set; }

        /* 
        public virtual tblLogoType tblLogoType { get; set; }

        public virtual tblUnit tblUnit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCompanyChangeLog> tblCompanyChangeLog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCompanyDomainRelation> tblCompanyDomainRelation { get; set; }

        public virtual tblCompanyLegalInfo tblCompanyLegalInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCompanyLegalInfo> tblCompanyLegalInfo1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCompanyWebsiteRelation> tblCompanyWebsiteRelation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDirectoryMaster> tblDirectoryMaster { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblLegalCompany> tblLegalCompany { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMyList> tblMyList { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPosition> tblPosition { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSubscription> tblSubscription { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUnit> tblUnit1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCompanySiteRelation> tblCompanySiteRelation { get; set; } */


    }
}
