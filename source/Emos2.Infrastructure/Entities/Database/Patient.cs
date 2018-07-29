namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Patient")]
    public partial class Patient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patient()
        {
            FastTrackVisits = new HashSet<FastTrackVisit>();
            Visits = new HashSet<Visit>();
        }

        public int ID { get; set; }

        [StringLength(15)]
        public string BIB { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        public int? Age { get; set; }

        [StringLength(1)]
        public string Gender { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public int? PrimaryLanguage { get; set; }

        [StringLength(100)]
        public string Contact { get; set; }

        [StringLength(100)]
        public string ContactRelation { get; set; }

        [StringLength(50)]
        public string ContactPhone { get; set; }

        public DateTime? Birthdate { get; set; }

        [StringLength(100)]
        public string StartAssigned { get; set; }

        [StringLength(100)]
        public string Charity { get; set; }

        [StringLength(50)]
        public string WristBand { get; set; }

        public int EventID { get; set; }

        public int? RaceID { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }

        [StringLength(100)]
        public string Country { get; set; }

        [StringLength(100)]
        public string ContactEmail { get; set; }

        public bool Communicate { get; set; }

        public virtual Event Event { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FastTrackVisit> FastTrackVisits { get; set; }

        public virtual Race Race { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Visit> Visits { get; set; }
    }
}
