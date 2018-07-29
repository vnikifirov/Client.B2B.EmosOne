namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vwVisit")]
    public partial class vwVisit
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
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

        public int? Status { get; set; }

        public int? TransportedHospital { get; set; }

        public int? TransferredTentID { get; set; }

        [StringLength(50)]
        public string BedName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string SectionName { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string TentName { get; set; }

        [StringLength(50)]
        public string Lng { get; set; }

        [StringLength(50)]
        public string Lat { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TentStatus { get; set; }

        public int? SectionID { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TentID { get; set; }

        [StringLength(15)]
        public string BIB { get; set; }

        [StringLength(50)]
        public string HospitalName { get; set; }

        [StringLength(50)]
        public string TransferredTentName { get; set; }

        public int? NotifyContact { get; set; }

        public int? Duration { get; set; }

        public bool? InformCEMStaffOrVolunteers { get; set; }

        [StringLength(100)]
        public string Country { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TypeID { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        public int? AttendingDoctor { get; set; }

        [StringLength(50)]
        public string WristBand { get; set; }

        public int? TransportingVehicleID { get; set; }

        [StringLength(50)]
        public string TransportingEMSName { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EventID { get; set; }
    }
}
