namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Visit")]
    public partial class Visit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Visit()
        {
            VisitContactNotes = new HashSet<VisitContactNote>();
            ChiefComplaints = new HashSet<ChiefComplaint>();
            Diagnoses = new HashSet<Diagnose>();
            Treatments = new HashSet<Treatment>();
        }

        public int ID { get; set; }

        public int PatientID { get; set; }

        public int? BedID { get; set; }

        public DateTime? CheckInTime { get; set; }

        [StringLength(250)]
        public string CheckInNote { get; set; }

        public int? CheckInStaffID { get; set; }

        public DateTime? CheckOutTime { get; set; }

        [StringLength(250)]
        public string CheckOutNote { get; set; }

        public int? CheckOutStaffID { get; set; }

        public int? AttendingDoctor { get; set; }

        public int? Status { get; set; }

        public int? TransportedHospital { get; set; }

        public int? NotifyContact { get; set; }

        public bool? InformCEMStaffOrVolunteers { get; set; }

        public int? TransferredTentID { get; set; }

        public int? TransportingVehicleID { get; set; }

        public decimal? Temperature { get; set; }

        public int? SodiumLevel { get; set; }

        public DateTime? AddmittedTime { get; set; }

        [StringLength(250)]
        public string AddmittedNote { get; set; }

        public int? AddmittedStaffID { get; set; }

        public int EventID { get; set; }

        public int? TentID { get; set; }

        public int? TransportMeansID { get; set; }

        public bool FamilyMemberWaiting { get; set; }

        public int? ShoeBrandID { get; set; }

        public int? ShoeModelID { get; set; }

        public int? ShoeAgeID { get; set; }

        [StringLength(255)]
        public string SymptomsPresentDuringTraining { get; set; }

        [StringLength(255)]
        public string SymptomsPresentDuration { get; set; }

        public virtual Bed Bed { get; set; }

        public virtual Doctor Doctor { get; set; }

        public virtual Event Event { get; set; }

        public virtual Hospital Hospital { get; set; }

        public virtual MedicalTent MedicalTent { get; set; }

        public virtual MedicalTent MedicalTent1 { get; set; }

        public virtual MedicalTent MedicalTent2 { get; set; }

        public virtual MedicalTentType MedicalTentType { get; set; }

        public virtual Patient Patient { get; set; }

        public virtual ShoeAge ShoeAge { get; set; }

        public virtual ShoeBrand ShoeBrand { get; set; }

        public virtual ShoeModel ShoeModel { get; set; }

        public virtual VisitStatu VisitStatu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitContactNote> VisitContactNotes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiefComplaint> ChiefComplaints { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Diagnose> Diagnoses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Treatment> Treatments { get; set; }
    }
}
