namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Event")]
    public partial class Event : IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Event()
        {
            AirfareRequests = new HashSet<AirfareRequest>();
            EventEmailServiceAccounts = new HashSet<EventEmailServiceAccount>();
            EventSettings = new HashSet<EventSetting>();
            EventSetupCheckLists = new HashSet<EventSetupCheckList>();
            HotelRequests = new HashSet<HotelRequest>();
            ItemAssignments = new HashSet<ItemAssignment>();
            ItemCheckInOuts = new HashSet<ItemCheckInOut>();
            ItemDistributionTypes = new HashSet<ItemDistributionType>();
            ItemRequests = new HashSet<ItemRequest>();
            Jobs = new HashSet<Job>();
            LocationAssignments = new HashSet<LocationAssignment>();
            Meals = new HashSet<Meal>();
            MedicalTents = new HashSet<MedicalTent>();
            OrganizationUnits = new HashSet<OrganizationUnit>();
            Participants = new HashSet<Participant>();
            Patients = new HashSet<Patient>();
            SecurityIssues = new HashSet<SecurityIssue>();
            SupportTickets = new HashSet<SupportTicket>();
            TimelineActivities = new HashSet<TimelineActivity>();
            Translators = new HashSet<Translator>();
            UniformTypes = new HashSet<UniformType>();
            UserFinancials = new HashSet<UserFinancial>();
            UserGuestInfoes = new HashSet<UserGuestInfo>();
            Vehicles = new HashSet<Vehicle>();
            VehicleTypes = new HashSet<VehicleType>();
            Visits = new HashSet<Visit>();
            VolunteerDesignations = new HashSet<VolunteerDesignation>();
            VolunteerEventCheckIns = new HashSet<VolunteerEventCheckIn>();
            VolunteerGroups = new HashSet<VolunteerGroup>();
            VolunteerJobs = new HashSet<VolunteerJob>();
            VolunteerJobAssignments = new HashSet<VolunteerJobAssignment>();
            VolunteerJobGroups = new HashSet<VolunteerJobGroup>();
            Weathers = new HashSet<Weather>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        public DateTime EventStart { get; set; }

        public DateTime EventEnd { get; set; }

        public DateTime? StartRegistration { get; set; }

        public DateTime? EndRegistration { get; set; }

        [StringLength(250)]
        public string Location { get; set; }

        [StringLength(50)]
        public string Lng { get; set; }

        [StringLength(50)]
        public string Lat { get; set; }

        public int StatusID { get; set; }

        [StringLength(100)]
        public string LogoImage { get; set; }

        [Required]
        [StringLength(100)]
        public string TimeZoneInfoId { get; set; }

        public string Waiver { get; set; }

        [StringLength(100)]
        public string HeaderImage { get; set; }

        [Column(TypeName = "ntext")]
        public string ConfidentialityAgreement { get; set; }

        [StringLength(100)]
        public string Abbreviation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AirfareRequest> AirfareRequests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventEmailServiceAccount> EventEmailServiceAccounts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventSetting> EventSettings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventSetupCheckList> EventSetupCheckLists { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HotelRequest> HotelRequests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemAssignment> ItemAssignments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemCheckInOut> ItemCheckInOuts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemDistributionType> ItemDistributionTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemRequest> ItemRequests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Job> Jobs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocationAssignment> LocationAssignments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Meal> Meals { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicalTent> MedicalTents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationUnit> OrganizationUnits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Participant> Participants { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Patient> Patients { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SecurityIssue> SecurityIssues { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupportTicket> SupportTickets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TimelineActivity> TimelineActivities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Translator> Translators { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UniformType> UniformTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserFinancial> UserFinancials { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserGuestInfo> UserGuestInfoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vehicle> Vehicles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VehicleType> VehicleTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Visit> Visits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VolunteerDesignation> VolunteerDesignations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VolunteerEventCheckIn> VolunteerEventCheckIns { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VolunteerGroup> VolunteerGroups { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VolunteerJob> VolunteerJobs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VolunteerJobAssignment> VolunteerJobAssignments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VolunteerJobGroup> VolunteerJobGroups { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Weather> Weathers { get; set; }
    }
}
