namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AirfareRequest")]
    public partial class AirfareRequest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AirfareRequest()
        {
            AirfareRequestStatus = new HashSet<AirfareRequestStatu>();
        }

        public int ID { get; set; }

        public int UserID { get; set; }

        public int? JobID { get; set; }

        public bool? NeedsAirFare { get; set; }

        [StringLength(50)]
        public string ConfirmationNumber { get; set; }

        public int EventID { get; set; }

        public int? OrganizationUnitID { get; set; }

        public virtual CEMUser CEMUser { get; set; }

        public virtual Event Event { get; set; }

        public virtual Job Job { get; set; }

        public virtual OrganizationUnit OrganizationUnit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AirfareRequestStatu> AirfareRequestStatus { get; set; }
    }
}
