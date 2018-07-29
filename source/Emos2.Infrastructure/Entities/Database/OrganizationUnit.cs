namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrganizationUnit")]
    public partial class OrganizationUnit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrganizationUnit()
        {
            AirfareRequests = new HashSet<AirfareRequest>();
            Charities = new HashSet<Charity>();
            EmailTemplateOrganizationalUnits = new HashSet<EmailTemplateOrganizationalUnit>();
            Exibitors = new HashSet<Exibitor>();
            HotelRequests = new HashSet<HotelRequest>();
            ItemRequests = new HashSet<ItemRequest>();
            Jobs = new HashSet<Job>();
            OrganizationUnit1 = new HashSet<OrganizationUnit>();
            Sponsors = new HashSet<Sponsor>();
            UserOrganizationUnits = new HashSet<UserOrganizationUnit>();
            Vendors = new HashSet<Vendor>();
            VolunteerJobs = new HashSet<VolunteerJob>();
            ItemDistributionTypes = new HashSet<ItemDistributionType>();
            ItemTypes = new HashSet<ItemType>();
            Jobs1 = new HashSet<Job>();
            Meals = new HashSet<Meal>();
            Items = new HashSet<Item>();
            SecurityZones = new HashSet<SecurityZone>();
            TimelineActivities = new HashSet<TimelineActivity>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(10)]
        public string TextColor { get; set; }

        [StringLength(10)]
        public string BackgroundColor { get; set; }

        public int? ParentID { get; set; }

        public int EventID { get; set; }

        public int? TypeID { get; set; }

        public int? PrimaryContactId { get; set; }

        [StringLength(20)]
        public string Lng { get; set; }

        [StringLength(20)]
        public string Lat { get; set; }

        public int? MapIconId { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AirfareRequest> AirfareRequests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Charity> Charities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmailTemplateOrganizationalUnit> EmailTemplateOrganizationalUnits { get; set; }

        public virtual Event Event { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Exibitor> Exibitors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HotelRequest> HotelRequests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemRequest> ItemRequests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Job> Jobs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationUnit> OrganizationUnit1 { get; set; }

        public virtual OrganizationUnit OrganizationUnit2 { get; set; }

        public virtual OrganizationUnitType OrganizationUnitType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sponsor> Sponsors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserOrganizationUnit> UserOrganizationUnits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vendor> Vendors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VolunteerJob> VolunteerJobs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemDistributionType> ItemDistributionTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemType> ItemTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Job> Jobs1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Meal> Meals { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item> Items { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SecurityZone> SecurityZones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TimelineActivity> TimelineActivities { get; set; }
    }
}
