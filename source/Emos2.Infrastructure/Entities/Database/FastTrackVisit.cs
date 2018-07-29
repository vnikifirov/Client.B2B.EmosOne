namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FastTrackVisit")]
    public partial class FastTrackVisit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FastTrackVisit()
        {
            FastTrackComplaints = new HashSet<FastTrackComplaint>();
            FastTrackItems = new HashSet<FastTrackItem>();
        }

        public int ID { get; set; }

        public int? PatientID { get; set; }

        public int? DischargeID { get; set; }

        public DateTime InterventionOn { get; set; }

        [StringLength(250)]
        public string Note { get; set; }

        public int StaffID { get; set; }

        public int MedicalTentID { get; set; }

        [StringLength(50)]
        public string BIB { get; set; }

        public int DoctorID { get; set; }

        public int EventID { get; set; }

        public virtual CEMUser CEMUser { get; set; }

        public virtual Doctor Doctor { get; set; }

        public virtual FastTrackDischarge FastTrackDischarge { get; set; }

        public virtual MedicalTent MedicalTent { get; set; }

        public virtual Patient Patient { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FastTrackComplaint> FastTrackComplaints { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FastTrackItem> FastTrackItems { get; set; }
    }
}
