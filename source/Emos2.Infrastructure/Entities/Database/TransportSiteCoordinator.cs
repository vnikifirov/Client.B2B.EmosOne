namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransportSiteCoordinator")]
    public partial class TransportSiteCoordinator
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TransportSiteCoordinator()
        {
            TransportBusRequests = new HashSet<TransportBusRequest>();
        }

        public int ID { get; set; }

        public int SiteID { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Role { get; set; }

        [Required]
        [StringLength(50)]
        public string CellPhone { get; set; }

        [StringLength(250)]
        public string Note { get; set; }

        public bool? OnEventDay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransportBusRequest> TransportBusRequests { get; set; }

        public virtual TransportSite TransportSite { get; set; }
    }
}
