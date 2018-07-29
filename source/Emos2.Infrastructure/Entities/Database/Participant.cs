namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Participant")]
    public partial class Participant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Participant()
        {
            ParticipantMedicalInfoes = new HashSet<ParticipantMedicalInfo>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(15)]
        public string BIB { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        public int? Age { get; set; }

        [StringLength(1)]
        public string Gender { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(100)]
        public string Contact { get; set; }

        [StringLength(100)]
        public string ContactRelation { get; set; }

        [StringLength(50)]
        public string ContactPhone { get; set; }

        public int? PrimaryLanguage { get; set; }

        public DateTime? Birthdate { get; set; }

        [StringLength(100)]
        public string StartAssigned { get; set; }

        [StringLength(100)]
        public string Charity { get; set; }

        public int? RaceID { get; set; }

        public string Note { get; set; }

        public int EventID { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(50)]
        public string ExternalID { get; set; }

        [StringLength(100)]
        public string Country { get; set; }

        [StringLength(100)]
        public string ContactEmail { get; set; }

        public bool Communicate { get; set; }

        public virtual Event Event { get; set; }

        public virtual Race Race { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ParticipantMedicalInfo> ParticipantMedicalInfoes { get; set; }
    }
}
