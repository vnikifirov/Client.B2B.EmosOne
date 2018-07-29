namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bed")]
    public partial class Bed
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bed()
        {
            Visits = new HashSet<Visit>();
        }

        public int ID { get; set; }

        public int? SectionID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? OrderNo { get; set; }

        public bool? IsAdditionalBed { get; set; }

        public virtual MedicalTentSection MedicalTentSection { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Visit> Visits { get; set; }
    }
}
