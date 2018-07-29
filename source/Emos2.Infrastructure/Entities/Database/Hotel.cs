namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hotel")]
    public partial class Hotel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hotel()
        {
            HotelRequestStatus = new HashSet<HotelRequestStatu>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [Column(TypeName = "text")]
        public string Note { get; set; }

        public bool Active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HotelRequestStatu> HotelRequestStatus { get; set; }
    }
}
