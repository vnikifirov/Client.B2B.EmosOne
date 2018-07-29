namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransportServiceCenter")]
    public partial class TransportServiceCenter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TransportServiceCenter()
        {
            TransportSites = new HashSet<TransportSite>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Abbreviation { get; set; }

        [StringLength(50)]
        public string Contact { get; set; }

        [StringLength(50)]
        public string Phone1 { get; set; }

        [StringLength(50)]
        public string Phone2 { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransportSite> TransportSites { get; set; }
    }
}
