namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Charity")]
    public partial class Charity
    {
        public int ID { get; set; }

        public int OrganizationUnitID { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        public int? ManagerID { get; set; }

        [StringLength(50)]
        public string Acronym { get; set; }

        [StringLength(250)]
        public string TeamName { get; set; }

        [StringLength(50)]
        public string TeamAcronym { get; set; }

        [StringLength(50)]
        public string Level { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        [StringLength(250)]
        public string Title { get; set; }

        [StringLength(250)]
        public string Role { get; set; }

        [StringLength(50)]
        public string ImageName { get; set; }

        [StringLength(50)]
        public string OfficePhone { get; set; }

        [StringLength(50)]
        public string EventDayPhone { get; set; }

        [StringLength(50)]
        public string EventDayVenue { get; set; }

        [StringLength(50)]
        public string EventDayVenueAddress { get; set; }

        [StringLength(50)]
        public string EventDayContactFirstName { get; set; }

        [StringLength(50)]
        public string EventDayContactLastName { get; set; }

        [StringLength(50)]
        public string EventDayContactNumber { get; set; }

        public bool? CharityBlockParty { get; set; }

        [StringLength(50)]
        public string CharityBlockPartyFirstName { get; set; }

        [StringLength(50)]
        public string CharityBlockPartyLastName { get; set; }

        [StringLength(50)]
        public string CharityBlockPartyNumber { get; set; }

        public virtual OrganizationUnit OrganizationUnit { get; set; }
    }
}
