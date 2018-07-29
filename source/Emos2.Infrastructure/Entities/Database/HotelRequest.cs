namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HotelRequest")]
    public partial class HotelRequest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HotelRequest()
        {
            HotelRequestStatus = new HashSet<HotelRequestStatu>();
            CEMUsers = new HashSet<CEMUser>();
        }

        public int ID { get; set; }

        public int? JobID { get; set; }

        public bool? NeedsHotel { get; set; }

        [StringLength(50)]
        public string ConfirmationNumber { get; set; }

        public DateTime? ConfirmationNumberSentOn { get; set; }

        public int EventID { get; set; }

        public int? OrganizationUnitID { get; set; }

        public decimal? RoomRate { get; set; }

        public int? PayingBy { get; set; }

        public int? BusinessUnitID { get; set; }

        public virtual BusinessUnit BusinessUnit { get; set; }

        public virtual Event Event { get; set; }

        public virtual Job Job { get; set; }

        public virtual OrganizationUnit OrganizationUnit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HotelRequestStatu> HotelRequestStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CEMUser> CEMUsers { get; set; }
    }
}
