namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MedicalTentSection")]
    public partial class MedicalTentSection
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MedicalTentSection()
        {
            Beds = new HashSet<Bed>();
        }

        public int ID { get; set; }

        public int TentID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int? OrderNo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bed> Beds { get; set; }

        public virtual MedicalTent MedicalTent { get; set; }
    }
}
