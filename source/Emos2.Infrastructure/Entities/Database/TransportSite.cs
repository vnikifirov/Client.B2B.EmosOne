namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransportSite")]
    public partial class TransportSite
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TransportSite()
        {
            TransportBusPaxUpdates = new HashSet<TransportBusPaxUpdate>();
            TransportBusRequests = new HashSet<TransportBusRequest>();
            TransportSiteCoordinators = new HashSet<TransportSiteCoordinator>();
            TransportBus = new HashSet<TransportBu>();
        }

        public int ID { get; set; }

        public int? DepotLocationID { get; set; }

        public int? CoralID { get; set; }

        public int? ServiceCenterID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [StringLength(50)]
        public string State { get; set; }

        [StringLength(50)]
        public string Zip { get; set; }

        [StringLength(50)]
        public string Lng { get; set; }

        [StringLength(50)]
        public string Lat { get; set; }

        public bool? NeedTransport { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransportBusPaxUpdate> TransportBusPaxUpdates { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransportBusRequest> TransportBusRequests { get; set; }

        public virtual TransportCoral TransportCoral { get; set; }

        public virtual TransportDepotLocation TransportDepotLocation { get; set; }

        public virtual TransportServiceCenter TransportServiceCenter { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransportSiteCoordinator> TransportSiteCoordinators { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransportBu> TransportBus { get; set; }
    }
}
