namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MedicalTent")]
    public partial class MedicalTent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MedicalTent()
        {
            FastTrackVisits = new HashSet<FastTrackVisit>();
            MedicalTentDiagnoses = new HashSet<MedicalTentDiagnose>();
            MedicalTentMandatoryFields = new HashSet<MedicalTentMandatoryField>();
            MedicalTentSections = new HashSet<MedicalTentSection>();
            MedicalTentTreatments = new HashSet<MedicalTentTreatment>();
            Visits = new HashSet<Visit>();
            Visits1 = new HashSet<Visit>();
            Visits2 = new HashSet<Visit>();
            Doctors = new HashSet<Doctor>();
            CEMUsers = new HashSet<CEMUser>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Lng { get; set; }

        [StringLength(50)]
        public string Lat { get; set; }

        public int? Color { get; set; }

        public int Status { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] timestamp { get; set; }

        [StringLength(50)]
        public string TentPrefix { get; set; }

        public int TypeID { get; set; }

        public bool ShowInTransferList { get; set; }

        public int EventID { get; set; }

        public bool HideTent { get; set; }

        public int? OrderNo { get; set; }

        public bool? IsShoeSectionActive { get; set; }

        public bool IsCheckInAdmitCombined { get; set; }

        public virtual Event Event { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FastTrackVisit> FastTrackVisits { get; set; }

        public virtual MedicalTentType MedicalTentType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicalTentDiagnose> MedicalTentDiagnoses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicalTentMandatoryField> MedicalTentMandatoryFields { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicalTentSection> MedicalTentSections { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicalTentTreatment> MedicalTentTreatments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Visit> Visits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Visit> Visits1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Visit> Visits2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Doctor> Doctors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CEMUser> CEMUsers { get; set; }
    }
}
