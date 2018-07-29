namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CEMUser")]
    public partial class CEMUser: IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CEMUser()
        {
            AirfareRequests = new HashSet<AirfareRequest>();
            AirfareRequestStatus = new HashSet<AirfareRequestStatu>();
            UserBadges = new HashSet<UserBadge>();
            UserCertifications = new HashSet<UserCertification>();
            UserMeetings = new HashSet<UserMeeting>();
            Contacts = new HashSet<Contact>();
            Emails = new HashSet<Email>();
            EventSetupCheckLists = new HashSet<EventSetupCheckList>();
            FastTrackVisits = new HashSet<FastTrackVisit>();
            HotelRequestStatus = new HashSet<HotelRequestStatu>();
            ItemAssignments = new HashSet<ItemAssignment>();
            ItemAssignments1 = new HashSet<ItemAssignment>();
            ItemCheckInOuts = new HashSet<ItemCheckInOut>();
            ItemCheckInOuts1 = new HashSet<ItemCheckInOut>();
            ItemCheckInOutStatus = new HashSet<ItemCheckInOutStatu>();
            ItemLocationLogs = new HashSet<ItemLocationLog>();
            ItemRequests = new HashSet<ItemRequest>();
            ItemRequestStatus = new HashSet<ItemRequestStatu>();
            ItemSets = new HashSet<ItemSet>();
            ItemSets1 = new HashSet<ItemSet>();
            Locations = new HashSet<Location>();
            LocationAssignments = new HashSet<LocationAssignment>();
            LocationAssignments1 = new HashSet<LocationAssignment>();
            Notifications = new HashSet<Notification>();
            ParticipantCheckIns = new HashSet<ParticipantCheckIn>();
            SecurityIssues = new HashSet<SecurityIssue>();
            SecurityIssueStatus = new HashSet<SecurityIssueStatu>();
            SendAllMessageToes = new HashSet<SendAllMessageTo>();
            SupportTickets = new HashSet<SupportTicket>();
            SurveyDistributions = new HashSet<SurveyDistribution>();
            TextMessages = new HashSet<TextMessage>();
            TimelineActivities = new HashSet<TimelineActivity>();
            TimelineActivityStatus = new HashSet<TimelineActivityStatu>();
            Translators = new HashSet<Translator>();
            TransportBusRequests = new HashSet<TransportBusRequest>();
            UserCertifications1 = new HashSet<UserCertification>();
            UserCRUDs = new HashSet<UserCRUD>();
            UserDatas = new HashSet<UserData>();
            UserEventCheckIns = new HashSet<UserEventCheckIn>();
            UserEventCheckIns1 = new HashSet<UserEventCheckIn>();
            UserFinancials = new HashSet<UserFinancial>();
            UserGuestInfoes = new HashSet<UserGuestInfo>();
            UserJobs = new HashSet<UserJob>();
            UserJobs1 = new HashSet<UserJob>();
            UserLocations = new HashSet<UserLocation>();
            UserOrganizationUnits = new HashSet<UserOrganizationUnit>();
            UserPermissionRoles = new HashSet<UserPermissionRole>();
            UserRadioChannels = new HashSet<UserRadioChannel>();
            UserSizes = new HashSet<UserSize>();
            UserSystemActions = new HashSet<UserSystemAction>();
            UserVehicleOnEventDays = new HashSet<UserVehicleOnEventDay>();
            UserVolunteerJobs = new HashSet<UserVolunteerJob>();
            VehicleCEMUsers = new HashSet<VehicleCEMUser>();
            VehicleTypeRequests = new HashSet<VehicleTypeRequest>();
            VisitContactNotes = new HashSet<VisitContactNote>();
            VolunteerEventCheckIns = new HashSet<VolunteerEventCheckIn>();
            VolunteerGroups = new HashSet<VolunteerGroup>();
            VolunteerGroups1 = new HashSet<VolunteerGroup>();
            VolunteerGroupAssignments = new HashSet<VolunteerGroupAssignment>();
            VolunteerJobAssignments = new HashSet<VolunteerJobAssignment>();
            VolunteerJobAssignments1 = new HashSet<VolunteerJobAssignment>();
            VolunteerJobAssignments2 = new HashSet<VolunteerJobAssignment>();
            HotelRequests = new HashSet<HotelRequest>();
            Languages = new HashSet<Language>();
            MedicalTents = new HashSet<MedicalTent>();
            SizeTypes = new HashSet<SizeType>();
            TimelineActivities1 = new HashSet<TimelineActivity>();
            VolunteerGroups2 = new HashSet<VolunteerGroup>();
            VolunteerJobShifts = new HashSet<VolunteerJobShift>();
            VolunteerDesignations = new HashSet<VolunteerDesignation>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(250)]
        public string StreetAddress { get; set; }

        [StringLength(250)]
        public string StreetAddress2 { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string State { get; set; }

        [StringLength(10)]
        public string Zip { get; set; }

        [StringLength(100)]
        public string Country { get; set; }

        [StringLength(50)]
        public string CellPhone { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public DateTime? DOB { get; set; }

        [StringLength(50)]
        public string ContactFirstName { get; set; }

        [StringLength(50)]
        public string ContactLastName { get; set; }

        [StringLength(50)]
        public string ContactPhone { get; set; }

        public string Description { get; set; }

        public int RoleID { get; set; }

        public bool Active { get; set; }

        public DateTime? DeactivationTime { get; set; }

        [Required]
        [StringLength(50)]
        public string BarCode { get; set; }

        [StringLength(50)]
        public string BarCodeLabel { get; set; }

        [StringLength(50)]
        public string ImageName { get; set; }

        public string OtherSpecialSkills { get; set; }

        public int? CEMContactID { get; set; }

        [StringLength(1)]
        public string Gender { get; set; }

        public int? CategoryID { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        [StringLength(50)]
        public string MiddleName { get; set; }

        public string AccessToken { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        public DateTime? TextOptIn { get; set; }

        public string PasswordHash { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AirfareRequest> AirfareRequests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AirfareRequestStatu> AirfareRequestStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserBadge> UserBadges { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserCertification> UserCertifications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserMeeting> UserMeetings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contact> Contacts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Email> Emails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventSetupCheckList> EventSetupCheckLists { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FastTrackVisit> FastTrackVisits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HotelRequestStatu> HotelRequestStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemAssignment> ItemAssignments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemAssignment> ItemAssignments1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemCheckInOut> ItemCheckInOuts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemCheckInOut> ItemCheckInOuts1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemCheckInOutStatu> ItemCheckInOutStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemLocationLog> ItemLocationLogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemRequest> ItemRequests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemRequestStatu> ItemRequestStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemSet> ItemSets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemSet> ItemSets1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Location> Locations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocationAssignment> LocationAssignments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocationAssignment> LocationAssignments1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Notification> Notifications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ParticipantCheckIn> ParticipantCheckIns { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SecurityIssue> SecurityIssues { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SecurityIssueStatu> SecurityIssueStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SendAllMessageTo> SendAllMessageToes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupportTicket> SupportTickets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SurveyDistribution> SurveyDistributions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TextMessage> TextMessages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TimelineActivity> TimelineActivities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TimelineActivityStatu> TimelineActivityStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Translator> Translators { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransportBusRequest> TransportBusRequests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserCertification> UserCertifications1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserCRUD> UserCRUDs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserData> UserDatas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserEventCheckIn> UserEventCheckIns { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserEventCheckIn> UserEventCheckIns1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserFinancial> UserFinancials { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserGuestInfo> UserGuestInfoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserJob> UserJobs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserJob> UserJobs1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserLocation> UserLocations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserOrganizationUnit> UserOrganizationUnits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserPermissionRole> UserPermissionRoles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserRadioChannel> UserRadioChannels { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserSize> UserSizes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserSystemAction> UserSystemActions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserVehicleOnEventDay> UserVehicleOnEventDays { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserVolunteerJob> UserVolunteerJobs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VehicleCEMUser> VehicleCEMUsers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VehicleTypeRequest> VehicleTypeRequests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitContactNote> VisitContactNotes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VolunteerEventCheckIn> VolunteerEventCheckIns { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VolunteerGroup> VolunteerGroups { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VolunteerGroup> VolunteerGroups1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VolunteerGroupAssignment> VolunteerGroupAssignments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VolunteerJobAssignment> VolunteerJobAssignments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VolunteerJobAssignment> VolunteerJobAssignments1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VolunteerJobAssignment> VolunteerJobAssignments2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HotelRequest> HotelRequests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Language> Languages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicalTent> MedicalTents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SizeType> SizeTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TimelineActivity> TimelineActivities1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VolunteerGroup> VolunteerGroups2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VolunteerJobShift> VolunteerJobShifts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VolunteerDesignation> VolunteerDesignations { get; set; }
    }
}
