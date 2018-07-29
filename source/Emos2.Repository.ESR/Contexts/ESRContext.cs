namespace Emos2.Repository.Entities.Database
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Emos2.Infrastructure.Entities.Database;

    public partial class ESRContext : EntitiesContextBase
    {
        public ESRContext()
            : base("name=ESRContext") 
        {
        }

        public virtual DbSet<AirfareRequest> AirfareRequests { get; set; }
        public virtual DbSet<AirfareRequestStatu> AirfareRequestStatus { get; set; }
        public virtual DbSet<Airport> Airports { get; set; }
        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<BannerNotification> BannerNotifications { get; set; }
        public virtual DbSet<Bed> Beds { get; set; }
        public virtual DbSet<Building> Buildings { get; set; }
        public virtual DbSet<BusinessUnit> BusinessUnits { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CEMUser> CEMUsers { get; set; }
        public virtual DbSet<Charity> Charities { get; set; }
        public virtual DbSet<CheckInLocation> CheckInLocations { get; set; }
        public virtual DbSet<ChiefComplaint> ChiefComplaints { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Diagnose> Diagnoses { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Email> Emails { get; set; }
        public virtual DbSet<EmailServiceAccount> EmailServiceAccounts { get; set; }
        public virtual DbSet<EmailTemplate> EmailTemplates { get; set; }
        public virtual DbSet<EmailTemplateAttachment> EmailTemplateAttachments { get; set; }
        public virtual DbSet<EmailTemplateOrganizationalUnit> EmailTemplateOrganizationalUnits { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<EventEmailServiceAccount> EventEmailServiceAccounts { get; set; }
        public virtual DbSet<EventSetting> EventSettings { get; set; }
        public virtual DbSet<EventSetupCheckList> EventSetupCheckLists { get; set; }
        public virtual DbSet<Exibitor> Exibitors { get; set; }
        public virtual DbSet<FastTrackComplaint> FastTrackComplaints { get; set; }
        public virtual DbSet<FastTrackDischarge> FastTrackDischarges { get; set; }
        public virtual DbSet<FastTrackItem> FastTrackItems { get; set; }
        public virtual DbSet<FastTrackVisit> FastTrackVisits { get; set; }
        public virtual DbSet<GeneralLedger> GeneralLedgers { get; set; }
        public virtual DbSet<Hospital> Hospitals { get; set; }
        public virtual DbSet<Hotel> Hotels { get; set; }
        public virtual DbSet<HotelRequest> HotelRequests { get; set; }
        public virtual DbSet<HotelRequestStatu> HotelRequestStatus { get; set; }
        public virtual DbSet<ImportLog> ImportLogs { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<ItemAssignment> ItemAssignments { get; set; }
        public virtual DbSet<ItemBackup> ItemBackups { get; set; }
        public virtual DbSet<ItemCheckInOut> ItemCheckInOuts { get; set; }
        public virtual DbSet<ItemCheckInOutStatu> ItemCheckInOutStatus { get; set; }
        public virtual DbSet<ItemDistributionType> ItemDistributionTypes { get; set; }
        public virtual DbSet<ItemExtSignage> ItemExtSignages { get; set; }
        public virtual DbSet<ItemImage> ItemImages { get; set; }
        public virtual DbSet<ItemLocation> ItemLocations { get; set; }
        public virtual DbSet<ItemLocationLog> ItemLocationLogs { get; set; }
        public virtual DbSet<ItemRequest> ItemRequests { get; set; }
        public virtual DbSet<ItemRequestStatu> ItemRequestStatus { get; set; }
        public virtual DbSet<ItemSet> ItemSets { get; set; }
        public virtual DbSet<ItemType> ItemTypes { get; set; }
        public virtual DbSet<ItemUniqueProperty> ItemUniqueProperties { get; set; }
        public virtual DbSet<ItemVendor> ItemVendors { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<JobItemAssignment> JobItemAssignments { get; set; }
        public virtual DbSet<JobRadioChannel> JobRadioChannels { get; set; }
        public virtual DbSet<JobShift> JobShifts { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<LocationAssignment> LocationAssignments { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Meal> Meals { get; set; }
        public virtual DbSet<MealTime> MealTimes { get; set; }
        public virtual DbSet<MedicalLicense> MedicalLicenses { get; set; }
        public virtual DbSet<MedicalServiceGroup> MedicalServiceGroups { get; set; }
        public virtual DbSet<MedicalServiceVolunteer> MedicalServiceVolunteers { get; set; }
        public virtual DbSet<MedicalTent> MedicalTents { get; set; }
        public virtual DbSet<MedicalTentDiagnose> MedicalTentDiagnoses { get; set; }
        public virtual DbSet<MedicalTentMandatoryField> MedicalTentMandatoryFields { get; set; }
        public virtual DbSet<MedicalTentSection> MedicalTentSections { get; set; }
        public virtual DbSet<MedicalTentTreatment> MedicalTentTreatments { get; set; }
        public virtual DbSet<MedicalTentType> MedicalTentTypes { get; set; }
        public virtual DbSet<MedicalTentTypeStatu> MedicalTentTypeStatus { get; set; }
        public virtual DbSet<Meeting> Meetings { get; set; }
        public virtual DbSet<MessageServiceAccount> MessageServiceAccounts { get; set; }
        public virtual DbSet<MobileDevice> MobileDevices { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<OrganizationUnit> OrganizationUnits { get; set; }
        public virtual DbSet<OrganizationUnitType> OrganizationUnitTypes { get; set; }
        public virtual DbSet<Participant> Participants { get; set; }
        public virtual DbSet<ParticipantCheckIn> ParticipantCheckIns { get; set; }
        public virtual DbSet<ParticipantMedicalInfo> ParticipantMedicalInfoes { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<PermissionRole> PermissionRoles { get; set; }
        public virtual DbSet<PermissionRoleSystemAction> PermissionRoleSystemActions { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<QuestionOption> QuestionOptions { get; set; }
        public virtual DbSet<Race> Races { get; set; }
        public virtual DbSet<RadioChannel> RadioChannels { get; set; }
        public virtual DbSet<SecurityIssue> SecurityIssues { get; set; }
        public virtual DbSet<SecurityIssueStatu> SecurityIssueStatus { get; set; }
        public virtual DbSet<SecurityZone> SecurityZones { get; set; }
        public virtual DbSet<SendAllMessageTo> SendAllMessageToes { get; set; }
        public virtual DbSet<ShoeAge> ShoeAges { get; set; }
        public virtual DbSet<ShoeBrand> ShoeBrands { get; set; }
        public virtual DbSet<ShoeModel> ShoeModels { get; set; }
        public virtual DbSet<Size> Sizes { get; set; }
        public virtual DbSet<SizeType> SizeTypes { get; set; }
        public virtual DbSet<SkillCertification> SkillCertifications { get; set; }
        public virtual DbSet<Sponsor> Sponsors { get; set; }
        public virtual DbSet<SupportTicket> SupportTickets { get; set; }
        public virtual DbSet<SupportTicketStatu> SupportTicketStatus { get; set; }
        public virtual DbSet<Survey> Surveys { get; set; }
        public virtual DbSet<SurveyDistribution> SurveyDistributions { get; set; }
        public virtual DbSet<TextMessage> TextMessages { get; set; }
        public virtual DbSet<TextMessageTemplate> TextMessageTemplates { get; set; }
        public virtual DbSet<TimelineActivity> TimelineActivities { get; set; }
        public virtual DbSet<TimelineActivityStatu> TimelineActivityStatus { get; set; }
        public virtual DbSet<Translator> Translators { get; set; }
        public virtual DbSet<TransportBu> TransportBus { get; set; }
        public virtual DbSet<TransportBusPaxUpdate> TransportBusPaxUpdates { get; set; }
        public virtual DbSet<TransportBusRequest> TransportBusRequests { get; set; }
        public virtual DbSet<TransportBusStatu> TransportBusStatus { get; set; }
        public virtual DbSet<TransportCoral> TransportCorals { get; set; }
        public virtual DbSet<TransportDepotLocation> TransportDepotLocations { get; set; }
        public virtual DbSet<TransportServiceCenter> TransportServiceCenters { get; set; }
        public virtual DbSet<TransportSite> TransportSites { get; set; }
        public virtual DbSet<TransportSiteCoordinator> TransportSiteCoordinators { get; set; }
        public virtual DbSet<Treatment> Treatments { get; set; }
        public virtual DbSet<UniformType> UniformTypes { get; set; }
        public virtual DbSet<UnitOfMeasure> UnitOfMeasures { get; set; }
        public virtual DbSet<UnitOfMeasurePackageCount> UnitOfMeasurePackageCounts { get; set; }
        public virtual DbSet<UnitOfMeasurePackageVolume> UnitOfMeasurePackageVolumes { get; set; }
        public virtual DbSet<UserBadge> UserBadges { get; set; }
        public virtual DbSet<UserCategory> UserCategories { get; set; }
        public virtual DbSet<UserCertification> UserCertifications { get; set; }
        public virtual DbSet<UserCRUD> UserCRUDs { get; set; }
        public virtual DbSet<UserData> UserDatas { get; set; }
        public virtual DbSet<UserEventCheckIn> UserEventCheckIns { get; set; }
        public virtual DbSet<UserFinancial> UserFinancials { get; set; }
        public virtual DbSet<UserGuestInfo> UserGuestInfoes { get; set; }
        public virtual DbSet<UserJob> UserJobs { get; set; }
        public virtual DbSet<UserLocation> UserLocations { get; set; }
        public virtual DbSet<UserLogin> UserLogins { get; set; }
        public virtual DbSet<UserMeeting> UserMeetings { get; set; }
        public virtual DbSet<UserOrganizationUnit> UserOrganizationUnits { get; set; }
        public virtual DbSet<UserPermissionRole> UserPermissionRoles { get; set; }
        public virtual DbSet<UserRadioChannel> UserRadioChannels { get; set; }
        public virtual DbSet<UserSize> UserSizes { get; set; }
        public virtual DbSet<UserSystemAction> UserSystemActions { get; set; }
        public virtual DbSet<UserVehicleOnEventDay> UserVehicleOnEventDays { get; set; }
        public virtual DbSet<UserVolunteerJob> UserVolunteerJobs { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<VehicleCategory> VehicleCategories { get; set; }
        public virtual DbSet<VehicleCEMUser> VehicleCEMUsers { get; set; }
        public virtual DbSet<VehicleGroup> VehicleGroups { get; set; }
        public virtual DbSet<VehicleLocation> VehicleLocations { get; set; }
        public virtual DbSet<VehicleLocationHistory> VehicleLocationHistories { get; set; }
        public virtual DbSet<VehicleNumberRange> VehicleNumberRanges { get; set; }
        public virtual DbSet<VehicleNumberRangeGroup> VehicleNumberRangeGroups { get; set; }
        public virtual DbSet<VehiclePackList> VehiclePackLists { get; set; }
        public virtual DbSet<VehiclePackListItem> VehiclePackListItems { get; set; }
        public virtual DbSet<VehicleProperty> VehicleProperties { get; set; }
        public virtual DbSet<VehicleRentalCompany> VehicleRentalCompanies { get; set; }
        public virtual DbSet<VehicleStickerType> VehicleStickerTypes { get; set; }
        public virtual DbSet<VehicleType> VehicleTypes { get; set; }
        public virtual DbSet<VehicleTypeRequest> VehicleTypeRequests { get; set; }
        public virtual DbSet<VehicleTypeRequestStatu> VehicleTypeRequestStatus { get; set; }
        public virtual DbSet<VehicleUseList> VehicleUseLists { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<Visit> Visits { get; set; }
        public virtual DbSet<VisitContactNote> VisitContactNotes { get; set; }
        public virtual DbSet<VisitStatu> VisitStatus { get; set; }
        public virtual DbSet<Volunteer> Volunteers { get; set; }
        public virtual DbSet<VolunteerCertification> VolunteerCertifications { get; set; }
        public virtual DbSet<VolunteerDesignation> VolunteerDesignations { get; set; }
        public virtual DbSet<VolunteerEventCheckIn> VolunteerEventCheckIns { get; set; }
        public virtual DbSet<VolunteerGroup> VolunteerGroups { get; set; }
        public virtual DbSet<VolunteerGroupAssignment> VolunteerGroupAssignments { get; set; }
        public virtual DbSet<VolunteerJob> VolunteerJobs { get; set; }
        public virtual DbSet<VolunteerJobAssignment> VolunteerJobAssignments { get; set; }
        public virtual DbSet<VolunteerJobGroup> VolunteerJobGroups { get; set; }
        public virtual DbSet<VolunteerJobShift> VolunteerJobShifts { get; set; }
        public virtual DbSet<VolunteerMedicalLicense> VolunteerMedicalLicenses { get; set; }
        public virtual DbSet<VolunteerSize> VolunteerSizes { get; set; }
        public virtual DbSet<Weather> Weathers { get; set; }
        public virtual DbSet<vwPositionSearch> vwPositionSearches { get; set; }
        public virtual DbSet<vwVisit> vwVisits { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AirfareRequest>()
                .Property(e => e.ConfirmationNumber)
                .IsUnicode(false);

            modelBuilder.Entity<AirfareRequestStatu>()
                .Property(e => e.DepartTime)
                .IsUnicode(false);

            modelBuilder.Entity<AirfareRequestStatu>()
                .Property(e => e.DepartArrivalTime)
                .IsUnicode(false);

            modelBuilder.Entity<AirfareRequestStatu>()
                .Property(e => e.DepartAirport)
                .IsUnicode(false);

            modelBuilder.Entity<AirfareRequestStatu>()
                .Property(e => e.DepartFlightNumber)
                .IsUnicode(false);

            modelBuilder.Entity<AirfareRequestStatu>()
                .Property(e => e.DepartSeatNumber)
                .IsUnicode(false);

            modelBuilder.Entity<AirfareRequestStatu>()
                .Property(e => e.ArriveAirport)
                .IsUnicode(false);

            modelBuilder.Entity<AirfareRequestStatu>()
                .Property(e => e.ReturnTime)
                .IsUnicode(false);

            modelBuilder.Entity<AirfareRequestStatu>()
                .Property(e => e.ReturnArrivalTime)
                .IsUnicode(false);

            modelBuilder.Entity<AirfareRequestStatu>()
                .Property(e => e.ReturnAirport)
                .IsUnicode(false);

            modelBuilder.Entity<AirfareRequestStatu>()
                .Property(e => e.ReturnFlightNumber)
                .IsUnicode(false);

            modelBuilder.Entity<AirfareRequestStatu>()
                .Property(e => e.ReturnSeatNumber)
                .IsUnicode(false);

            modelBuilder.Entity<AirfareRequestStatu>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<AirfareRequestStatu>()
                .Property(e => e.TripType)
                .IsUnicode(false);

            modelBuilder.Entity<AirfareRequestStatu>()
                .Property(e => e.DepartAirline)
                .IsUnicode(false);

            modelBuilder.Entity<AirfareRequestStatu>()
                .Property(e => e.ReturnAirline)
                .IsUnicode(false);

            modelBuilder.Entity<Airport>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Airport>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Airport>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Bed>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Building>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Building>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Building>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Building>()
                .Property(e => e.ImageName)
                .IsUnicode(false);

            modelBuilder.Entity<BusinessUnit>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<BusinessUnit>()
                .HasMany(e => e.VehicleTypeRequests)
                .WithOptional(e => e.BusinessUnit)
                .HasForeignKey(e => e.BUID)
                .WillCascadeOnDelete();

            modelBuilder.Entity<BusinessUnit>()
                .HasMany(e => e.VehicleTypeRequests1)
                .WithOptional(e => e.BusinessUnit1)
                .HasForeignKey(e => e.BUID2);

            modelBuilder.Entity<Category>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.TextColor)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.BackgroundColor)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Category1)
                .WithOptional(e => e.Category2)
                .HasForeignKey(e => e.ParentID);

            modelBuilder.Entity<CEMUser>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<CEMUser>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<CEMUser>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<CEMUser>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<CEMUser>()
                .Property(e => e.StreetAddress)
                .IsUnicode(false);

            modelBuilder.Entity<CEMUser>()
                .Property(e => e.StreetAddress2)
                .IsUnicode(false);

            modelBuilder.Entity<CEMUser>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<CEMUser>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<CEMUser>()
                .Property(e => e.Zip)
                .IsUnicode(false);

            modelBuilder.Entity<CEMUser>()
                .Property(e => e.CellPhone)
                .IsUnicode(false);

            modelBuilder.Entity<CEMUser>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<CEMUser>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<CEMUser>()
                .Property(e => e.ContactFirstName)
                .IsUnicode(false);

            modelBuilder.Entity<CEMUser>()
                .Property(e => e.ContactLastName)
                .IsUnicode(false);

            modelBuilder.Entity<CEMUser>()
                .Property(e => e.ContactPhone)
                .IsUnicode(false);

            modelBuilder.Entity<CEMUser>()
                .Property(e => e.BarCode)
                .IsUnicode(false);

            modelBuilder.Entity<CEMUser>()
                .Property(e => e.BarCodeLabel)
                .IsUnicode(false);

            modelBuilder.Entity<CEMUser>()
                .Property(e => e.ImageName)
                .IsUnicode(false);

            modelBuilder.Entity<CEMUser>()
                .Property(e => e.Gender)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CEMUser>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<CEMUser>()
                .Property(e => e.AccessToken)
                .IsUnicode(false);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.AirfareRequests)
                .WithRequired(e => e.CEMUser)
                .HasForeignKey(e => e.UserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.AirfareRequestStatus)
                .WithOptional(e => e.CEMUser)
                .HasForeignKey(e => e.StatusBy);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.UserBadges)
                .WithRequired(e => e.CEMUser)
                .HasForeignKey(e => e.UserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.UserCertifications)
                .WithRequired(e => e.CEMUser)
                .HasForeignKey(e => e.UserID);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.UserMeetings)
                .WithRequired(e => e.CEMUser)
                .HasForeignKey(e => e.UserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.Contacts)
                .WithRequired(e => e.CEMUser)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.Emails)
                .WithOptional(e => e.CEMUser)
                .HasForeignKey(e => e.UserID);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.EventSetupCheckLists)
                .WithRequired(e => e.CEMUser)
                .HasForeignKey(e => e.StatusBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.FastTrackVisits)
                .WithRequired(e => e.CEMUser)
                .HasForeignKey(e => e.StaffID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.HotelRequestStatus)
                .WithOptional(e => e.CEMUser)
                .HasForeignKey(e => e.StatusBy);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.ItemAssignments)
                .WithRequired(e => e.CEMUser)
                .HasForeignKey(e => e.AssignTo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.ItemAssignments1)
                .WithRequired(e => e.CEMUser1)
                .HasForeignKey(e => e.AuthorizeBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.ItemCheckInOuts)
                .WithRequired(e => e.CEMUser)
                .HasForeignKey(e => e.CheckBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.ItemCheckInOuts1)
                .WithRequired(e => e.CEMUser1)
                .HasForeignKey(e => e.AuthorizedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.ItemCheckInOutStatus)
                .WithRequired(e => e.CEMUser)
                .HasForeignKey(e => e.StatusBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.ItemLocationLogs)
                .WithRequired(e => e.CEMUser)
                .HasForeignKey(e => e.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.ItemRequests)
                .WithRequired(e => e.CEMUser)
                .HasForeignKey(e => e.RequestedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.ItemRequestStatus)
                .WithRequired(e => e.CEMUser)
                .HasForeignKey(e => e.StatusBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.ItemSets)
                .WithRequired(e => e.CEMUser)
                .HasForeignKey(e => e.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.ItemSets1)
                .WithOptional(e => e.CEMUser1)
                .HasForeignKey(e => e.UpdatedBy);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.Locations)
                .WithOptional(e => e.CEMUser)
                .HasForeignKey(e => e.CreatedBy);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.LocationAssignments)
                .WithRequired(e => e.CEMUser)
                .HasForeignKey(e => e.AssignTo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.LocationAssignments1)
                .WithRequired(e => e.CEMUser1)
                .HasForeignKey(e => e.AuthorizeBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.Notifications)
                .WithRequired(e => e.CEMUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.ParticipantCheckIns)
                .WithOptional(e => e.CEMUser)
                .HasForeignKey(e => e.StatusBy);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.SecurityIssues)
                .WithRequired(e => e.CEMUser)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.SecurityIssueStatus)
                .WithRequired(e => e.CEMUser)
                .HasForeignKey(e => e.StatusBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.SendAllMessageToes)
                .WithRequired(e => e.CEMUser)
                .HasForeignKey(e => e.UserID);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.SupportTickets)
                .WithOptional(e => e.CEMUser)
                .HasForeignKey(e => e.CreatedBy);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.SurveyDistributions)
                .WithOptional(e => e.CEMUser)
                .HasForeignKey(e => e.UserID)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.TextMessages)
                .WithOptional(e => e.CEMUser)
                .HasForeignKey(e => e.UserID);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.TimelineActivities)
                .WithOptional(e => e.CEMUser)
                .HasForeignKey(e => e.StatusBy);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.TimelineActivityStatus)
                .WithOptional(e => e.CEMUser)
                .HasForeignKey(e => e.StatusBy);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.Translators)
                .WithRequired(e => e.CEMUser)
                .HasForeignKey(e => e.UserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.TransportBusRequests)
                .WithOptional(e => e.CEMUser)
                .HasForeignKey(e => e.ConfirmedBy);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.UserCertifications1)
                .WithOptional(e => e.CEMUser1)
                .HasForeignKey(e => e.StatusBy);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.UserCRUDs)
                .WithRequired(e => e.CEMUser)
                .HasForeignKey(e => e.UserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.UserDatas)
                .WithRequired(e => e.CEMUser)
                .HasForeignKey(e => e.UserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.UserEventCheckIns)
                .WithRequired(e => e.CEMUser)
                .HasForeignKey(e => e.UserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.UserEventCheckIns1)
                .WithOptional(e => e.CEMUser1)
                .HasForeignKey(e => e.CheckedBy);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.UserFinancials)
                .WithRequired(e => e.CEMUser)
                .HasForeignKey(e => e.UserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.UserGuestInfoes)
                .WithRequired(e => e.CEMUser)
                .HasForeignKey(e => e.UserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.UserJobs)
                .WithRequired(e => e.CEMUser)
                .HasForeignKey(e => e.UserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.UserJobs1)
                .WithOptional(e => e.CEMUser1)
                .HasForeignKey(e => e.WorkedSetBy);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.UserLocations)
                .WithRequired(e => e.CEMUser)
                .HasForeignKey(e => e.UserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.UserOrganizationUnits)
                .WithRequired(e => e.CEMUser)
                .HasForeignKey(e => e.UserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.UserPermissionRoles)
                .WithRequired(e => e.CEMUser)
                .HasForeignKey(e => e.UserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.UserRadioChannels)
                .WithRequired(e => e.CEMUser)
                .HasForeignKey(e => e.UserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.UserSizes)
                .WithRequired(e => e.CEMUser)
                .HasForeignKey(e => e.UserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.UserSystemActions)
                .WithRequired(e => e.CEMUser)
                .HasForeignKey(e => e.UserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.UserVehicleOnEventDays)
                .WithRequired(e => e.CEMUser)
                .HasForeignKey(e => e.UserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.UserVolunteerJobs)
                .WithRequired(e => e.CEMUser)
                .HasForeignKey(e => e.UserID);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.VehicleCEMUsers)
                .WithRequired(e => e.CEMUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.VehicleTypeRequests)
                .WithRequired(e => e.CEMUser)
                .HasForeignKey(e => e.UserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.VisitContactNotes)
                .WithRequired(e => e.CEMUser)
                .HasForeignKey(e => e.UserID);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.VolunteerEventCheckIns)
                .WithRequired(e => e.CEMUser)
                .HasForeignKey(e => e.VolunteerID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.VolunteerGroups)
                .WithOptional(e => e.CEMUser)
                .HasForeignKey(e => e.ApprovedBy);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.VolunteerGroups1)
                .WithOptional(e => e.CEMUser1)
                .HasForeignKey(e => e.CreatedBy);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.VolunteerGroupAssignments)
                .WithRequired(e => e.CEMUser)
                .HasForeignKey(e => e.VolunteerID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.VolunteerJobAssignments)
                .WithOptional(e => e.CEMUser)
                .HasForeignKey(e => e.ConfirmedBy);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.VolunteerJobAssignments1)
                .WithOptional(e => e.CEMUser1)
                .HasForeignKey(e => e.RejectedBy);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.VolunteerJobAssignments2)
                .WithRequired(e => e.CEMUser2)
                .HasForeignKey(e => e.VolunteerID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.HotelRequests)
                .WithMany(e => e.CEMUsers)
                .Map(m => m.ToTable("UserHotelRequest").MapLeftKey("UserID").MapRightKey("HotelRequestID"));

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.Languages)
                .WithMany(e => e.CEMUsers)
                .Map(m => m.ToTable("UserLanguage").MapLeftKey("UserID").MapRightKey("LanguageID"));

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.MedicalTents)
                .WithMany(e => e.CEMUsers)
                .Map(m => m.ToTable("UserMedicalTent").MapLeftKey("UserID").MapRightKey("TentID"));

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.SizeTypes)
                .WithMany(e => e.CEMUsers)
                .Map(m => m.ToTable("UserSizeType").MapLeftKey("UserID").MapRightKey("SizeTypeID"));

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.TimelineActivities1)
                .WithMany(e => e.CEMUsers)
                .Map(m => m.ToTable("UserTimelineActivity").MapLeftKey("UserID").MapRightKey("TimelineActivityID"));

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.VolunteerGroups2)
                .WithMany(e => e.CEMUsers)
                .Map(m => m.ToTable("UserVolunteerGroup").MapLeftKey("UserID").MapRightKey("VolunteerGroupID"));

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.VolunteerJobShifts)
                .WithMany(e => e.CEMUsers)
                .Map(m => m.ToTable("UserVolunteerJobShift").MapLeftKey("UserID").MapRightKey("VolunteerJobShiftID"));

            modelBuilder.Entity<CEMUser>()
                .HasMany(e => e.VolunteerDesignations)
                .WithMany(e => e.CEMUsers)
                .Map(m => m.ToTable("VolunteerDesignationAssignment").MapLeftKey("VolunteerID").MapRightKey("DesignationID"));

            modelBuilder.Entity<Charity>()
                .Property(e => e.Acronym)
                .IsUnicode(false);

            modelBuilder.Entity<Charity>()
                .Property(e => e.TeamName)
                .IsUnicode(false);

            modelBuilder.Entity<Charity>()
                .Property(e => e.TeamAcronym)
                .IsUnicode(false);

            modelBuilder.Entity<Charity>()
                .Property(e => e.Level)
                .IsUnicode(false);

            modelBuilder.Entity<Charity>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Charity>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Charity>()
                .Property(e => e.Role)
                .IsUnicode(false);

            modelBuilder.Entity<Charity>()
                .Property(e => e.ImageName)
                .IsUnicode(false);

            modelBuilder.Entity<Charity>()
                .Property(e => e.OfficePhone)
                .IsUnicode(false);

            modelBuilder.Entity<Charity>()
                .Property(e => e.EventDayPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Charity>()
                .Property(e => e.EventDayVenue)
                .IsUnicode(false);

            modelBuilder.Entity<Charity>()
                .Property(e => e.EventDayVenueAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Charity>()
                .Property(e => e.EventDayContactFirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Charity>()
                .Property(e => e.EventDayContactLastName)
                .IsUnicode(false);

            modelBuilder.Entity<Charity>()
                .Property(e => e.EventDayContactNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Charity>()
                .Property(e => e.CharityBlockPartyFirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Charity>()
                .Property(e => e.CharityBlockPartyLastName)
                .IsUnicode(false);

            modelBuilder.Entity<Charity>()
                .Property(e => e.CharityBlockPartyNumber)
                .IsUnicode(false);

            modelBuilder.Entity<CheckInLocation>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CheckInLocation>()
                .Property(e => e.Lng)
                .IsUnicode(false);

            modelBuilder.Entity<CheckInLocation>()
                .Property(e => e.Lat)
                .IsUnicode(false);

            modelBuilder.Entity<CheckInLocation>()
                .HasMany(e => e.ParticipantCheckIns)
                .WithRequired(e => e.CheckInLocation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CheckInLocation>()
                .HasMany(e => e.VolunteerEventCheckIns)
                .WithRequired(e => e.CheckInLocation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ChiefComplaint>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ChiefComplaint>()
                .HasMany(e => e.Visits)
                .WithMany(e => e.ChiefComplaints)
                .Map(m => m.ToTable("VisitChiefComplaint").MapLeftKey("ChiefComplaintID").MapRightKey("VisitID"));

            modelBuilder.Entity<Contact>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.A2Code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.A3Code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Languages)
                .WithMany(e => e.Countries)
                .Map(m => m.ToTable("CountryLanguage").MapLeftKey("CountryID").MapRightKey("LanguageID"));

            modelBuilder.Entity<Diagnose>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Diagnose>()
                .HasMany(e => e.MedicalTentDiagnoses)
                .WithRequired(e => e.Diagnose)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Diagnose>()
                .HasMany(e => e.Visits)
                .WithMany(e => e.Diagnoses)
                .Map(m => m.ToTable("VisitDiagnose").MapLeftKey("DiagnoseID").MapRightKey("VisitID"));

            modelBuilder.Entity<Doctor>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Doctor>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Doctor>()
                .HasMany(e => e.FastTrackVisits)
                .WithRequired(e => e.Doctor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Doctor>()
                .HasMany(e => e.Visits)
                .WithOptional(e => e.Doctor)
                .HasForeignKey(e => e.AttendingDoctor);

            modelBuilder.Entity<Doctor>()
                .HasMany(e => e.MedicalTents)
                .WithMany(e => e.Doctors)
                .Map(m => m.ToTable("DoctorMedicalTent").MapLeftKey("DoctorID").MapRightKey("MedicalTentID"));

            modelBuilder.Entity<Email>()
                .Property(e => e.ExceptionDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Email>()
                .Property(e => e.ReplyTo)
                .IsUnicode(false);

            modelBuilder.Entity<EmailServiceAccount>()
                .Property(e => e.EmailSender)
                .IsUnicode(false);

            modelBuilder.Entity<EmailServiceAccount>()
                .Property(e => e.SMTPServer)
                .IsUnicode(false);

            modelBuilder.Entity<EmailServiceAccount>()
                .Property(e => e.SMTPUsername)
                .IsUnicode(false);

            modelBuilder.Entity<EmailServiceAccount>()
                .Property(e => e.SMTPPassword)
                .IsUnicode(false);

            modelBuilder.Entity<EmailServiceAccount>()
                .HasMany(e => e.EventEmailServiceAccounts)
                .WithRequired(e => e.EmailServiceAccount)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmailTemplate>()
                .Property(e => e.Placeholders)
                .IsUnicode(false);

            modelBuilder.Entity<EmailTemplate>()
                .HasMany(e => e.Emails)
                .WithRequired(e => e.EmailTemplate)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmailTemplate>()
                .HasMany(e => e.EmailTemplateAttachments)
                .WithRequired(e => e.EmailTemplate)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmailTemplate>()
                .HasMany(e => e.EmailTemplateOrganizationalUnits)
                .WithRequired(e => e.EmailTemplate)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .Property(e => e.Lng)
                .IsUnicode(false);

            modelBuilder.Entity<Event>()
                .Property(e => e.Lat)
                .IsUnicode(false);

            modelBuilder.Entity<Event>()
                .Property(e => e.LogoImage)
                .IsUnicode(false);

            modelBuilder.Entity<Event>()
                .Property(e => e.TimeZoneInfoId)
                .IsUnicode(false);

            modelBuilder.Entity<Event>()
                .Property(e => e.HeaderImage)
                .IsUnicode(false);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.AirfareRequests)
                .WithRequired(e => e.Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.EventEmailServiceAccounts)
                .WithRequired(e => e.Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.EventSettings)
                .WithRequired(e => e.Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.EventSetupCheckLists)
                .WithRequired(e => e.Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.HotelRequests)
                .WithRequired(e => e.Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.ItemAssignments)
                .WithRequired(e => e.Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.ItemRequests)
                .WithRequired(e => e.Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.Jobs)
                .WithRequired(e => e.Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.LocationAssignments)
                .WithRequired(e => e.Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.MedicalTents)
                .WithRequired(e => e.Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.OrganizationUnits)
                .WithRequired(e => e.Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.Participants)
                .WithRequired(e => e.Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.Patients)
                .WithRequired(e => e.Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.SecurityIssues)
                .WithRequired(e => e.Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.TimelineActivities)
                .WithRequired(e => e.Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.Translators)
                .WithRequired(e => e.Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.UniformTypes)
                .WithRequired(e => e.Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.UserFinancials)
                .WithRequired(e => e.Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.UserGuestInfoes)
                .WithRequired(e => e.Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.Vehicles)
                .WithRequired(e => e.Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.VehicleTypes)
                .WithRequired(e => e.Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.Visits)
                .WithRequired(e => e.Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.VolunteerDesignations)
                .WithRequired(e => e.Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.VolunteerEventCheckIns)
                .WithRequired(e => e.Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.VolunteerGroups)
                .WithRequired(e => e.Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.VolunteerJobs)
                .WithRequired(e => e.Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.VolunteerJobAssignments)
                .WithRequired(e => e.Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.VolunteerJobGroups)
                .WithRequired(e => e.Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.Weathers)
                .WithRequired(e => e.Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EventEmailServiceAccount>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<EventEmailServiceAccount>()
                .Property(e => e.ReplyTo)
                .IsUnicode(false);

            modelBuilder.Entity<EventSetting>()
                .Property(e => e.SettingKey)
                .IsUnicode(false);

            modelBuilder.Entity<Exibitor>()
                .Property(e => e.WebSite)
                .IsUnicode(false);

            modelBuilder.Entity<Exibitor>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Exibitor>()
                .Property(e => e.ImageName)
                .IsUnicode(false);

            modelBuilder.Entity<Exibitor>()
                .Property(e => e.OfficePhone)
                .IsUnicode(false);

            modelBuilder.Entity<FastTrackComplaint>()
                .HasMany(e => e.FastTrackVisits)
                .WithMany(e => e.FastTrackComplaints)
                .Map(m => m.ToTable("FastTrackVisitComplaint").MapLeftKey("ComplaintID").MapRightKey("VisitID"));

            modelBuilder.Entity<FastTrackDischarge>()
                .HasMany(e => e.FastTrackVisits)
                .WithOptional(e => e.FastTrackDischarge)
                .HasForeignKey(e => e.DischargeID);

            modelBuilder.Entity<FastTrackItem>()
                .HasMany(e => e.FastTrackVisits)
                .WithMany(e => e.FastTrackItems)
                .Map(m => m.ToTable("FastTrackVisitItem").MapLeftKey("ItemID").MapRightKey("VisitID"));

            modelBuilder.Entity<FastTrackVisit>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<FastTrackVisit>()
                .Property(e => e.BIB)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralLedger>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralLedger>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralLedger>()
                .HasMany(e => e.VehicleTypes)
                .WithOptional(e => e.GeneralLedger)
                .HasForeignKey(e => e.GLID);

            modelBuilder.Entity<Hospital>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Hospital>()
                .Property(e => e.timestamp)
                .IsFixedLength();

            modelBuilder.Entity<Hospital>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Hospital>()
                .HasMany(e => e.Visits)
                .WithOptional(e => e.Hospital)
                .HasForeignKey(e => e.TransportedHospital);

            modelBuilder.Entity<Hotel>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Hotel>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Hotel>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<HotelRequest>()
                .Property(e => e.ConfirmationNumber)
                .IsUnicode(false);

            modelBuilder.Entity<HotelRequest>()
                .Property(e => e.RoomRate)
                .HasPrecision(18, 0);

            modelBuilder.Entity<HotelRequestStatu>()
                .Property(e => e.RoomType)
                .IsUnicode(false);

            modelBuilder.Entity<HotelRequestStatu>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<ImportLog>()
                .Property(e => e.ImportFileName)
                .IsUnicode(false);

            modelBuilder.Entity<ImportLog>()
                .Property(e => e.ExceptionFileName)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Item>()
                .Property(e => e.VendorProductCode)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.BarCode)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.BarCodeLable)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.ItemAssignments)
                .WithRequired(e => e.Item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.ItemCheckInOuts)
                .WithRequired(e => e.Item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasOptional(e => e.ItemExtSignage)
                .WithRequired(e => e.Item);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.ItemLocations)
                .WithRequired(e => e.Item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.ItemRequests)
                .WithRequired(e => e.Item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.ItemSets)
                .WithRequired(e => e.Item)
                .HasForeignKey(e => e.ItemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.ItemSets1)
                .WithOptional(e => e.Item1)
                .HasForeignKey(e => e.ParentID);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.ItemUniqueProperties)
                .WithRequired(e => e.Item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.JobItemAssignments)
                .WithRequired(e => e.Item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.ItemDistributionTypes)
                .WithMany(e => e.Items)
                .Map(m => m.ToTable("ItemDistribution").MapLeftKey("ItemID").MapRightKey("ItemDistributionTypeID"));

            modelBuilder.Entity<Item>()
                .HasMany(e => e.OrganizationUnits)
                .WithMany(e => e.Items)
                .Map(m => m.ToTable("OrganizationUnitItemAssignment").MapLeftKey("ItemID").MapRightKey("OrganizationUnitID"));

            modelBuilder.Entity<Item>()
                .HasMany(e => e.OrganizationUnitTypes)
                .WithMany(e => e.Items)
                .Map(m => m.ToTable("OrganizationUnitTypeItemAssignment").MapLeftKey("ItemID").MapRightKey("OrganizationUnitTypeID"));

            modelBuilder.Entity<Item>()
                .HasMany(e => e.UniformTypes)
                .WithMany(e => e.Items)
                .Map(m => m.ToTable("UniformTypeItem").MapLeftKey("ItemID").MapRightKey("UniformTypeID"));

            modelBuilder.Entity<Item>()
                .HasMany(e => e.VolunteerJobs)
                .WithMany(e => e.Items)
                .Map(m => m.ToTable("VolunteerJobItemAssignment").MapLeftKey("ItemID").MapRightKey("VolunteerJobID"));

            modelBuilder.Entity<ItemAssignment>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<ItemBackup>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ItemBackup>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ItemBackup>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<ItemBackup>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ItemBackup>()
                .Property(e => e.VendorProductCode)
                .IsUnicode(false);

            modelBuilder.Entity<ItemBackup>()
                .Property(e => e.BarCode)
                .IsUnicode(false);

            modelBuilder.Entity<ItemBackup>()
                .Property(e => e.BarCodeLable)
                .IsUnicode(false);

            modelBuilder.Entity<ItemCheckInOut>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<ItemDistributionType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ItemDistributionType>()
                .HasMany(e => e.ItemDistributionType1)
                .WithOptional(e => e.ItemDistributionType2)
                .HasForeignKey(e => e.ParentID);

            modelBuilder.Entity<ItemDistributionType>()
                .HasMany(e => e.OrganizationUnits)
                .WithMany(e => e.ItemDistributionTypes)
                .Map(m => m.ToTable("ItemDistirbutionTypeUnitRequets").MapLeftKey("ItemDistributionTypeID").MapRightKey("OrganizationUnitID"));

            modelBuilder.Entity<ItemImage>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<ItemImage>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ItemRequest>()
                .HasMany(e => e.ItemRequestStatus)
                .WithRequired(e => e.ItemRequest)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ItemType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ItemType>()
                .HasMany(e => e.Items)
                .WithRequired(e => e.ItemType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ItemType>()
                .HasMany(e => e.ItemType1)
                .WithOptional(e => e.ItemType2)
                .HasForeignKey(e => e.ParentID);

            modelBuilder.Entity<ItemType>()
                .HasMany(e => e.OrganizationUnits)
                .WithMany(e => e.ItemTypes)
                .Map(m => m.ToTable("ItemTypeOrganizationUnitRequest").MapLeftKey("ItemTypeID").MapRightKey("OrganizationUnitID"));

            modelBuilder.Entity<ItemUniqueProperty>()
                .Property(e => e.UniqueProperty)
                .IsUnicode(false);

            modelBuilder.Entity<ItemUniqueProperty>()
                .HasMany(e => e.ItemAssignments)
                .WithOptional(e => e.ItemUniqueProperty)
                .HasForeignKey(e => e.UniquePropertyID);

            modelBuilder.Entity<ItemUniqueProperty>()
                .HasMany(e => e.ItemCheckInOuts)
                .WithOptional(e => e.ItemUniqueProperty)
                .HasForeignKey(e => e.UniquePropertyID);

            modelBuilder.Entity<ItemUniqueProperty>()
                .HasMany(e => e.ItemLocations)
                .WithOptional(e => e.ItemUniqueProperty)
                .HasForeignKey(e => e.UniquePropertyID);

            modelBuilder.Entity<ItemUniqueProperty>()
                .HasMany(e => e.ItemLocationLogs)
                .WithOptional(e => e.ItemUniqueProperty)
                .HasForeignKey(e => e.UniquePropertyID);

            modelBuilder.Entity<ItemVendor>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ItemVendor>()
                .HasMany(e => e.Items)
                .WithOptional(e => e.ItemVendor)
                .HasForeignKey(e => e.VendorID);

            modelBuilder.Entity<Job>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.PayRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Job>()
                .HasMany(e => e.JobItemAssignments)
                .WithRequired(e => e.Job)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Job>()
                .HasMany(e => e.JobRadioChannels)
                .WithRequired(e => e.Job)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Job>()
                .HasMany(e => e.JobShifts)
                .WithRequired(e => e.Job)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Job>()
                .HasMany(e => e.OrganizationUnits)
                .WithMany(e => e.Jobs1)
                .Map(m => m.ToTable("JobOrganizationUnit").MapLeftKey("JobID").MapRightKey("OrganizationUnit"));

            modelBuilder.Entity<Job>()
                .HasMany(e => e.PermissionRoles)
                .WithMany(e => e.Jobs)
                .Map(m => m.ToTable("JobPermissionRole").MapLeftKey("JobID").MapRightKey("PremissionRoleID"));

            modelBuilder.Entity<Job>()
                .HasMany(e => e.SecurityZones)
                .WithMany(e => e.Jobs)
                .Map(m => m.ToTable("JobSecurityZone").MapLeftKey("JobID").MapRightKey("SecurityZone"));

            modelBuilder.Entity<Job>()
                .HasMany(e => e.SkillCertifications)
                .WithMany(e => e.Jobs)
                .Map(m => m.ToTable("JobSkillCertification").MapLeftKey("JobID").MapRightKey("SkilCertification"));

            modelBuilder.Entity<JobItemAssignment>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Language>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Language>()
                .Property(e => e.FlagImage)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.ContactPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.ImageName)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.BarCode)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.BarCodeLable)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.TextColor)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.BackgroundColor)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .HasMany(e => e.ItemCheckInOuts)
                .WithOptional(e => e.Location)
                .HasForeignKey(e => e.CheckLocation);

            modelBuilder.Entity<Location>()
                .HasMany(e => e.ItemLocations)
                .WithRequired(e => e.Location)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Location>()
                .HasMany(e => e.ItemLocationLogs)
                .WithOptional(e => e.Location)
                .HasForeignKey(e => e.LocationFromID);

            modelBuilder.Entity<Location>()
                .HasMany(e => e.ItemLocationLogs1)
                .WithOptional(e => e.Location1)
                .HasForeignKey(e => e.LocationToID);

            modelBuilder.Entity<Location>()
                .HasMany(e => e.Location1)
                .WithOptional(e => e.Location2)
                .HasForeignKey(e => e.ParentID);

            modelBuilder.Entity<Location>()
                .HasMany(e => e.LocationAssignments)
                .WithRequired(e => e.Location)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Location>()
                .HasMany(e => e.VehiclePackListItems)
                .WithOptional(e => e.Location)
                .HasForeignKey(e => e.ContainerID);

            modelBuilder.Entity<LocationAssignment>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<Meal>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Meal>()
                .HasMany(e => e.MealTimes)
                .WithRequired(e => e.Meal)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Meal>()
                .HasMany(e => e.OrganizationUnits)
                .WithMany(e => e.Meals)
                .Map(m => m.ToTable("MealOrgnizationUnit").MapLeftKey("MealID").MapRightKey("OrganizationUnitID"));

            modelBuilder.Entity<MedicalLicense>()
                .Property(e => e.LicenseNumber)
                .IsUnicode(false);

            modelBuilder.Entity<MedicalLicense>()
                .Property(e => e.IssuingState)
                .IsUnicode(false);

            modelBuilder.Entity<MedicalLicense>()
                .Property(e => e.ImageName)
                .IsUnicode(false);

            modelBuilder.Entity<MedicalLicense>()
                .HasMany(e => e.VolunteerMedicalLicenses)
                .WithRequired(e => e.MedicalLicense)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MedicalServiceGroup>()
                .Property(e => e.TextColor)
                .IsUnicode(false);

            modelBuilder.Entity<MedicalServiceGroup>()
                .Property(e => e.BackgroundColor)
                .IsUnicode(false);

            modelBuilder.Entity<MedicalServiceGroup>()
                .HasMany(e => e.MedicalServiceGroup1)
                .WithOptional(e => e.MedicalServiceGroup2)
                .HasForeignKey(e => e.ParentID);

            modelBuilder.Entity<MedicalServiceGroup>()
                .HasMany(e => e.MedicalServiceVolunteers)
                .WithMany(e => e.MedicalServiceGroups)
                .Map(m => m.ToTable("MedicalServiceVolunteerGroup").MapLeftKey("GroupID").MapRightKey("VolunteerID"));

            modelBuilder.Entity<MedicalTent>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<MedicalTent>()
                .Property(e => e.Lng)
                .IsUnicode(false);

            modelBuilder.Entity<MedicalTent>()
                .Property(e => e.Lat)
                .IsUnicode(false);

            modelBuilder.Entity<MedicalTent>()
                .Property(e => e.timestamp)
                .IsFixedLength();

            modelBuilder.Entity<MedicalTent>()
                .Property(e => e.TentPrefix)
                .IsUnicode(false);

            modelBuilder.Entity<MedicalTent>()
                .HasMany(e => e.FastTrackVisits)
                .WithRequired(e => e.MedicalTent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MedicalTent>()
                .HasMany(e => e.MedicalTentDiagnoses)
                .WithRequired(e => e.MedicalTent)
                .HasForeignKey(e => e.TentID);

            modelBuilder.Entity<MedicalTent>()
                .HasMany(e => e.MedicalTentMandatoryFields)
                .WithRequired(e => e.MedicalTent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MedicalTent>()
                .HasMany(e => e.MedicalTentSections)
                .WithRequired(e => e.MedicalTent)
                .HasForeignKey(e => e.TentID);

            modelBuilder.Entity<MedicalTent>()
                .HasMany(e => e.MedicalTentTreatments)
                .WithRequired(e => e.MedicalTent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MedicalTent>()
                .HasMany(e => e.Visits)
                .WithOptional(e => e.MedicalTent)
                .HasForeignKey(e => e.TentID);

            modelBuilder.Entity<MedicalTent>()
                .HasMany(e => e.Visits1)
                .WithOptional(e => e.MedicalTent1)
                .HasForeignKey(e => e.TransferredTentID);

            modelBuilder.Entity<MedicalTent>()
                .HasMany(e => e.Visits2)
                .WithOptional(e => e.MedicalTent2)
                .HasForeignKey(e => e.TransportingVehicleID);

            modelBuilder.Entity<MedicalTentSection>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<MedicalTentSection>()
                .HasMany(e => e.Beds)
                .WithOptional(e => e.MedicalTentSection)
                .HasForeignKey(e => e.SectionID)
                .WillCascadeOnDelete();

            modelBuilder.Entity<MedicalTentType>()
                .HasMany(e => e.MedicalTents)
                .WithRequired(e => e.MedicalTentType)
                .HasForeignKey(e => e.TypeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MedicalTentType>()
                .HasMany(e => e.MedicalTentTypeStatus)
                .WithRequired(e => e.MedicalTentType)
                .HasForeignKey(e => e.TypeID);

            modelBuilder.Entity<MedicalTentType>()
                .HasMany(e => e.Visits)
                .WithOptional(e => e.MedicalTentType)
                .HasForeignKey(e => e.TransportMeansID);

            modelBuilder.Entity<Meeting>()
                .Property(e => e.EventID)
                .IsFixedLength();

            modelBuilder.Entity<Meeting>()
                .Property(e => e.Lng)
                .IsUnicode(false);

            modelBuilder.Entity<Meeting>()
                .Property(e => e.AddToTimeline)
                .IsFixedLength();

            modelBuilder.Entity<Meeting>()
                .Property(e => e.Lat)
                .IsUnicode(false);

            modelBuilder.Entity<Meeting>()
                .HasMany(e => e.UserMeetings)
                .WithRequired(e => e.Meeting)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MessageServiceAccount>()
                .Property(e => e.SMSHttpRequest)
                .IsUnicode(false);

            modelBuilder.Entity<MessageServiceAccount>()
                .Property(e => e.SMSUserName)
                .IsUnicode(false);

            modelBuilder.Entity<MessageServiceAccount>()
                .Property(e => e.SMSPassword)
                .IsUnicode(false);

            modelBuilder.Entity<MessageServiceAccount>()
                .Property(e => e.SMSAPI_ID)
                .IsUnicode(false);

            modelBuilder.Entity<MessageServiceAccount>()
                .HasMany(e => e.TextMessageTemplates)
                .WithRequired(e => e.MessageServiceAccount)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationUnit>()
                .Property(e => e.TextColor)
                .IsUnicode(false);

            modelBuilder.Entity<OrganizationUnit>()
                .Property(e => e.BackgroundColor)
                .IsUnicode(false);

            modelBuilder.Entity<OrganizationUnit>()
                .Property(e => e.Lng)
                .IsUnicode(false);

            modelBuilder.Entity<OrganizationUnit>()
                .Property(e => e.Lat)
                .IsUnicode(false);

            modelBuilder.Entity<OrganizationUnit>()
                .HasMany(e => e.Charities)
                .WithRequired(e => e.OrganizationUnit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationUnit>()
                .HasMany(e => e.EmailTemplateOrganizationalUnits)
                .WithOptional(e => e.OrganizationUnit)
                .HasForeignKey(e => e.UnitID);

            modelBuilder.Entity<OrganizationUnit>()
                .HasMany(e => e.Exibitors)
                .WithRequired(e => e.OrganizationUnit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationUnit>()
                .HasMany(e => e.Jobs)
                .WithRequired(e => e.OrganizationUnit)
                .HasForeignKey(e => e.OrganizationUnitID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationUnit>()
                .HasMany(e => e.OrganizationUnit1)
                .WithOptional(e => e.OrganizationUnit2)
                .HasForeignKey(e => e.ParentID);

            modelBuilder.Entity<OrganizationUnit>()
                .HasMany(e => e.Sponsors)
                .WithRequired(e => e.OrganizationUnit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationUnit>()
                .HasMany(e => e.UserOrganizationUnits)
                .WithRequired(e => e.OrganizationUnit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationUnit>()
                .HasMany(e => e.Vendors)
                .WithRequired(e => e.OrganizationUnit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationUnit>()
                .HasMany(e => e.VolunteerJobs)
                .WithRequired(e => e.OrganizationUnit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationUnit>()
                .HasMany(e => e.SecurityZones)
                .WithMany(e => e.OrganizationUnits)
                .Map(m => m.ToTable("OrganizationUnitSecurityZone").MapLeftKey("OrganizaitonUnitID").MapRightKey("SecurityZoneID"));

            modelBuilder.Entity<OrganizationUnit>()
                .HasMany(e => e.TimelineActivities)
                .WithMany(e => e.OrganizationUnits)
                .Map(m => m.ToTable("TimelineActivityOrganizationUnit").MapLeftKey("OrganizationUnitID").MapRightKey("TimelineActivityID"));

            modelBuilder.Entity<OrganizationUnitType>()
                .Property(e => e.RegistrationLink)
                .IsUnicode(false);

            modelBuilder.Entity<OrganizationUnitType>()
                .HasMany(e => e.OrganizationUnits)
                .WithOptional(e => e.OrganizationUnitType)
                .HasForeignKey(e => e.TypeID);

            modelBuilder.Entity<OrganizationUnitType>()
                .HasMany(e => e.Surveys)
                .WithMany(e => e.OrganizationUnitTypes)
                .Map(m => m.ToTable("SurveyOrganizationUnitType").MapLeftKey("OrganizationUnitTypeID").MapRightKey("SurveyID"));

            modelBuilder.Entity<Participant>()
                .Property(e => e.BIB)
                .IsUnicode(false);

            modelBuilder.Entity<Participant>()
                .Property(e => e.Gender)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Participant>()
                .Property(e => e.ContactPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Participant>()
                .Property(e => e.StartAssigned)
                .IsUnicode(false);

            modelBuilder.Entity<Participant>()
                .Property(e => e.Charity)
                .IsUnicode(false);

            modelBuilder.Entity<Participant>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Participant>()
                .Property(e => e.ExternalID)
                .IsUnicode(false);

            modelBuilder.Entity<Participant>()
                .Property(e => e.ContactEmail)
                .IsUnicode(false);

            modelBuilder.Entity<Participant>()
                .HasMany(e => e.ParticipantMedicalInfoes)
                .WithRequired(e => e.Participant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ParticipantCheckIn>()
                .Property(e => e.BIB)
                .IsUnicode(false);

            modelBuilder.Entity<ParticipantCheckIn>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<ParticipantMedicalInfo>()
                .Property(e => e.Physician)
                .IsUnicode(false);

            modelBuilder.Entity<ParticipantMedicalInfo>()
                .Property(e => e.PhysicianPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.BIB)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.Gender)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.ContactPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.StartAssigned)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.Charity)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.WristBand)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.ContactEmail)
                .IsUnicode(false);

            modelBuilder.Entity<PermissionRole>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<PermissionRole>()
                .HasMany(e => e.PermissionRoleSystemActions)
                .WithRequired(e => e.PermissionRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PermissionRole>()
                .HasMany(e => e.UserPermissionRoles)
                .WithRequired(e => e.PermissionRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Question>()
                .Property(e => e.QuestionGroup)
                .IsUnicode(false);

            modelBuilder.Entity<Question>()
                .HasMany(e => e.Answers)
                .WithRequired(e => e.Question)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Question>()
                .HasMany(e => e.QuestionOptions)
                .WithRequired(e => e.Question)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Race>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Race>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<RadioChannel>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<RadioChannel>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<RadioChannel>()
                .HasMany(e => e.JobRadioChannels)
                .WithRequired(e => e.RadioChannel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RadioChannel>()
                .HasMany(e => e.UserRadioChannels)
                .WithRequired(e => e.RadioChannel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SecurityZone>()
                .HasMany(e => e.UniformTypes)
                .WithMany(e => e.SecurityZones)
                .Map(m => m.ToTable("UniformTypeSecurityZone").MapLeftKey("SecurityZoneID").MapRightKey("UniformTypeID"));

            modelBuilder.Entity<Size>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Size>()
                .HasMany(e => e.UserSizes)
                .WithRequired(e => e.Size)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Size>()
                .HasMany(e => e.VolunteerSizes)
                .WithRequired(e => e.Size)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SizeType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<SizeType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<SizeType>()
                .Property(e => e.SizeChartImageName)
                .IsUnicode(false);

            modelBuilder.Entity<SizeType>()
                .HasMany(e => e.Sizes)
                .WithRequired(e => e.SizeType)
                .HasForeignKey(e => e.TypeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SizeType>()
                .HasMany(e => e.UserSizes)
                .WithRequired(e => e.SizeType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SizeType>()
                .HasMany(e => e.VolunteerSizes)
                .WithRequired(e => e.SizeType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SkillCertification>()
                .Property(e => e.GroupName)
                .IsUnicode(false);

            modelBuilder.Entity<SkillCertification>()
                .HasMany(e => e.UserCertifications)
                .WithRequired(e => e.SkillCertification)
                .HasForeignKey(e => e.CertficationID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SkillCertification>()
                .HasMany(e => e.VolunteerCertifications)
                .WithRequired(e => e.SkillCertification)
                .HasForeignKey(e => e.CertficationID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SkillCertification>()
                .HasMany(e => e.VehicleTypes)
                .WithMany(e => e.SkillCertifications)
                .Map(m => m.ToTable("VehicleTypeCertification").MapLeftKey("SkillCertificationID").MapRightKey("VehcileTypeID"));

            modelBuilder.Entity<SkillCertification>()
                .HasMany(e => e.VolunteerDesignations)
                .WithMany(e => e.SkillCertifications)
                .Map(m => m.ToTable("VolunteerDesignationCertification").MapLeftKey("CertificationID").MapRightKey("DesignationID"));

            modelBuilder.Entity<SkillCertification>()
                .HasMany(e => e.VolunteerJobs)
                .WithMany(e => e.SkillCertifications)
                .Map(m => m.ToTable("VolunteerJobCertification").MapLeftKey("SkillCertificationID").MapRightKey("VolunteerJobID"));

            modelBuilder.Entity<Sponsor>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Sponsor>()
                .Property(e => e.WebSite)
                .IsUnicode(false);

            modelBuilder.Entity<Sponsor>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Sponsor>()
                .Property(e => e.ImageName)
                .IsUnicode(false);

            modelBuilder.Entity<Sponsor>()
                .Property(e => e.OfficePhone)
                .IsUnicode(false);

            modelBuilder.Entity<SupportTicket>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<SupportTicket>()
                .Property(e => e.ConatctEmail)
                .IsUnicode(false);

            modelBuilder.Entity<SupportTicket>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<SupportTicket>()
                .HasMany(e => e.SupportTicketStatus)
                .WithRequired(e => e.SupportTicket)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Survey>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Survey>()
                .HasMany(e => e.Questions)
                .WithRequired(e => e.Survey)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Survey>()
                .HasMany(e => e.SurveyDistributions)
                .WithRequired(e => e.Survey)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SurveyDistribution>()
                .HasMany(e => e.Answers)
                .WithRequired(e => e.SurveyDistribution)
                .HasForeignKey(e => e.DistributionID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TextMessage>()
                .Property(e => e.ExceptionDesc)
                .IsUnicode(false);

            modelBuilder.Entity<TextMessageTemplate>()
                .HasMany(e => e.TextMessages)
                .WithRequired(e => e.TextMessageTemplate)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TimelineActivityStatu>()
                .Property(e => e.StatusLat)
                .IsUnicode(false);

            modelBuilder.Entity<TimelineActivityStatu>()
                .Property(e => e.StatusLng)
                .IsUnicode(false);

            modelBuilder.Entity<TransportBu>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<TransportBu>()
                .Property(e => e.Driver)
                .IsUnicode(false);

            modelBuilder.Entity<TransportBu>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<TransportBu>()
                .Property(e => e.ConfirmationNumber)
                .IsUnicode(false);

            modelBuilder.Entity<TransportBu>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<TransportBu>()
                .HasMany(e => e.TransportBusPaxUpdates)
                .WithRequired(e => e.TransportBu)
                .HasForeignKey(e => e.BusID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TransportBu>()
                .HasMany(e => e.TransportBusStatus)
                .WithRequired(e => e.TransportBu)
                .HasForeignKey(e => e.BusID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TransportBu>()
                .HasMany(e => e.TransportSites)
                .WithMany(e => e.TransportBus)
                .Map(m => m.ToTable("TransportSiteBus").MapLeftKey("BusID").MapRightKey("SiteID"));

            modelBuilder.Entity<TransportBusPaxUpdate>()
                .Property(e => e.StatusBy)
                .IsUnicode(false);

            modelBuilder.Entity<TransportBusPaxUpdate>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<TransportBusRequest>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<TransportBusStatu>()
                .Property(e => e.StatusBy)
                .IsUnicode(false);

            modelBuilder.Entity<TransportBusStatu>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<TransportCoral>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<TransportCoral>()
                .Property(e => e.StartAt)
                .IsUnicode(false);

            modelBuilder.Entity<TransportCoral>()
                .HasMany(e => e.TransportSites)
                .WithOptional(e => e.TransportCoral)
                .HasForeignKey(e => e.CoralID);

            modelBuilder.Entity<TransportDepotLocation>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<TransportDepotLocation>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<TransportDepotLocation>()
                .Property(e => e.CityStateZip)
                .IsUnicode(false);

            modelBuilder.Entity<TransportDepotLocation>()
                .Property(e => e.Lng)
                .IsUnicode(false);

            modelBuilder.Entity<TransportDepotLocation>()
                .Property(e => e.Lat)
                .IsUnicode(false);

            modelBuilder.Entity<TransportDepotLocation>()
                .HasMany(e => e.TransportSites)
                .WithOptional(e => e.TransportDepotLocation)
                .HasForeignKey(e => e.DepotLocationID);

            modelBuilder.Entity<TransportServiceCenter>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<TransportServiceCenter>()
                .Property(e => e.Abbreviation)
                .IsUnicode(false);

            modelBuilder.Entity<TransportServiceCenter>()
                .Property(e => e.Contact)
                .IsUnicode(false);

            modelBuilder.Entity<TransportServiceCenter>()
                .Property(e => e.Phone1)
                .IsUnicode(false);

            modelBuilder.Entity<TransportServiceCenter>()
                .Property(e => e.Phone2)
                .IsUnicode(false);

            modelBuilder.Entity<TransportServiceCenter>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<TransportServiceCenter>()
                .HasMany(e => e.TransportSites)
                .WithOptional(e => e.TransportServiceCenter)
                .HasForeignKey(e => e.ServiceCenterID);

            modelBuilder.Entity<TransportSite>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<TransportSite>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<TransportSite>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<TransportSite>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<TransportSite>()
                .Property(e => e.Zip)
                .IsUnicode(false);

            modelBuilder.Entity<TransportSite>()
                .Property(e => e.Lng)
                .IsUnicode(false);

            modelBuilder.Entity<TransportSite>()
                .Property(e => e.Lat)
                .IsUnicode(false);

            modelBuilder.Entity<TransportSite>()
                .HasMany(e => e.TransportBusPaxUpdates)
                .WithRequired(e => e.TransportSite)
                .HasForeignKey(e => e.SiteID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TransportSite>()
                .HasMany(e => e.TransportBusRequests)
                .WithRequired(e => e.TransportSite)
                .HasForeignKey(e => e.SiteID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TransportSite>()
                .HasMany(e => e.TransportSiteCoordinators)
                .WithRequired(e => e.TransportSite)
                .HasForeignKey(e => e.SiteID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TransportSiteCoordinator>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<TransportSiteCoordinator>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<TransportSiteCoordinator>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<TransportSiteCoordinator>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<TransportSiteCoordinator>()
                .Property(e => e.Role)
                .IsUnicode(false);

            modelBuilder.Entity<TransportSiteCoordinator>()
                .Property(e => e.CellPhone)
                .IsUnicode(false);

            modelBuilder.Entity<TransportSiteCoordinator>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<TransportSiteCoordinator>()
                .HasMany(e => e.TransportBusRequests)
                .WithOptional(e => e.TransportSiteCoordinator)
                .HasForeignKey(e => e.RequestBy);

            modelBuilder.Entity<Treatment>()
                .HasMany(e => e.MedicalTentTreatments)
                .WithRequired(e => e.Treatment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Treatment>()
                .HasMany(e => e.Visits)
                .WithMany(e => e.Treatments)
                .Map(m => m.ToTable("VisitTreatment").MapLeftKey("TreatmentID").MapRightKey("VisitID"));

            modelBuilder.Entity<UniformType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<UniformType>()
                .HasMany(e => e.Jobs)
                .WithOptional(e => e.UniformType1)
                .HasForeignKey(e => e.UniformType);

            modelBuilder.Entity<UnitOfMeasure>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<UnitOfMeasure>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<UnitOfMeasure>()
                .HasMany(e => e.Items)
                .WithOptional(e => e.UnitOfMeasure)
                .HasForeignKey(e => e.UnitID);

            modelBuilder.Entity<UnitOfMeasurePackageCount>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<UnitOfMeasurePackageCount>()
                .HasMany(e => e.Items)
                .WithOptional(e => e.UnitOfMeasurePackageCount)
                .HasForeignKey(e => e.UnitPackageID);

            modelBuilder.Entity<UnitOfMeasurePackageVolume>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<UnitOfMeasurePackageVolume>()
                .HasMany(e => e.Items)
                .WithOptional(e => e.UnitOfMeasurePackageVolume)
                .HasForeignKey(e => e.UnitVolumeID);

            modelBuilder.Entity<UserCategory>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<UserCategory>()
                .Property(e => e.RegisterURL)
                .IsUnicode(false);

            modelBuilder.Entity<UserCategory>()
                .Property(e => e.RedirectURL)
                .IsUnicode(false);

            modelBuilder.Entity<UserCertification>()
                .Property(e => e.ImageName)
                .IsUnicode(false);

            modelBuilder.Entity<UserFinancial>()
                .Property(e => e.PayTo)
                .IsUnicode(false);

            modelBuilder.Entity<UserGuestInfo>()
                .Property(e => e.Company)
                .IsUnicode(false);

            modelBuilder.Entity<UserGuestInfo>()
                .Property(e => e.Hotel)
                .IsUnicode(false);

            modelBuilder.Entity<UserJob>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<UserLocation>()
                .Property(e => e.Lng)
                .IsUnicode(false);

            modelBuilder.Entity<UserLocation>()
                .Property(e => e.Lat)
                .IsUnicode(false);

            modelBuilder.Entity<UserLogin>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<UserVehicleOnEventDay>()
                .Property(e => e.LicensePlateNumber)
                .IsUnicode(false);

            modelBuilder.Entity<UserVehicleOnEventDay>()
                .Property(e => e.Model)
                .IsUnicode(false);

            modelBuilder.Entity<UserVehicleOnEventDay>()
                .Property(e => e.Make)
                .IsUnicode(false);

            modelBuilder.Entity<UserVehicleOnEventDay>()
                .Property(e => e.PlateState)
                .IsUnicode(false);

            modelBuilder.Entity<UserVehicleOnEventDay>()
                .Property(e => e.DriverName)
                .IsUnicode(false);

            modelBuilder.Entity<UserVehicleOnEventDay>()
                .Property(e => e.DriverPhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.LicencePlate)
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.BarCode)
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.BarCodeLable)
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.ImageName)
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.LicencePlateState)
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.InternalNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.Make)
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.Model)
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .HasMany(e => e.VehicleCEMUsers)
                .WithRequired(e => e.Vehicle)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vehicle>()
                .HasMany(e => e.VehicleLocationHistories)
                .WithRequired(e => e.Vehicle)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vehicle>()
                .HasMany(e => e.VehicleTypeRequests)
                .WithOptional(e => e.Vehicle)
                .HasForeignKey(e => e.ConfirmedVehicleID);

            modelBuilder.Entity<VehicleCategory>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleCategory>()
                .Property(e => e.ImageName)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleCategory>()
                .HasMany(e => e.VehicleTypes)
                .WithOptional(e => e.VehicleCategory)
                .HasForeignKey(e => e.CategoryID);

            modelBuilder.Entity<VehicleCEMUser>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleGroup>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleGroup>()
                .HasMany(e => e.Vehicles)
                .WithOptional(e => e.VehicleGroup)
                .HasForeignKey(e => e.GroupID);

            modelBuilder.Entity<VehicleLocation>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleLocation>()
                .Property(e => e.Descripton)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleLocation>()
                .Property(e => e.Lng)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleLocation>()
                .Property(e => e.Lat)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleLocation>()
                .HasMany(e => e.VehicleLocationHistories)
                .WithRequired(e => e.VehicleLocation)
                .HasForeignKey(e => e.LocationID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VehicleNumberRange>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleNumberRangeGroup>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleNumberRangeGroup>()
                .HasMany(e => e.VehicleNumberRanges)
                .WithRequired(e => e.VehicleNumberRangeGroup)
                .HasForeignKey(e => e.GroupId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VehiclePackList>()
                .Property(e => e.CellPhone)
                .IsUnicode(false);

            modelBuilder.Entity<VehiclePackList>()
                .Property(e => e.LoadingLocation)
                .IsUnicode(false);

            modelBuilder.Entity<VehiclePackList>()
                .Property(e => e.DestinationLocation)
                .IsUnicode(false);

            modelBuilder.Entity<VehiclePackListItem>()
                .Property(e => e.ItemName)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleProperty>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleRentalCompany>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleRentalCompany>()
                .HasMany(e => e.Vehicles)
                .WithOptional(e => e.VehicleRentalCompany)
                .HasForeignKey(e => e.RentalCompanyID);

            modelBuilder.Entity<VehicleStickerType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleStickerType>()
                .HasMany(e => e.Vehicles)
                .WithOptional(e => e.VehicleStickerType)
                .HasForeignKey(e => e.StickerTypeID);

            modelBuilder.Entity<VehicleType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleType>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<VehicleType>()
                .Property(e => e.ImageName)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleType>()
                .HasMany(e => e.Vehicles)
                .WithOptional(e => e.VehicleType)
                .HasForeignKey(e => e.TypeID);

            modelBuilder.Entity<VehicleType>()
                .HasMany(e => e.VehicleTypeRequests)
                .WithRequired(e => e.VehicleType)
                .HasForeignKey(e => e.TypeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VehicleTypeRequest>()
                .Property(e => e.Driver)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleTypeRequest>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleTypeRequest>()
                .HasMany(e => e.VehicleTypeRequestStatus)
                .WithRequired(e => e.VehicleTypeRequest)
                .HasForeignKey(e => e.RequestID);

            modelBuilder.Entity<VehicleUseList>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleUseList>()
                .HasMany(e => e.Vehicles)
                .WithOptional(e => e.VehicleUseList)
                .HasForeignKey(e => e.UseListID);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.WebSite)
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.ImageName)
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.OfficePhone)
                .IsUnicode(false);

            modelBuilder.Entity<Visit>()
                .Property(e => e.CheckInNote)
                .IsUnicode(false);

            modelBuilder.Entity<Visit>()
                .Property(e => e.CheckOutNote)
                .IsUnicode(false);

            modelBuilder.Entity<Visit>()
                .Property(e => e.AddmittedNote)
                .IsUnicode(false);

            modelBuilder.Entity<Visit>()
                .Property(e => e.SymptomsPresentDuringTraining)
                .IsUnicode(false);

            modelBuilder.Entity<Visit>()
                .Property(e => e.SymptomsPresentDuration)
                .IsUnicode(false);

            modelBuilder.Entity<VisitStatu>()
                .HasMany(e => e.MedicalTentTypeStatus)
                .WithRequired(e => e.VisitStatu)
                .HasForeignKey(e => e.StatusID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VisitStatu>()
                .HasMany(e => e.Visits)
                .WithOptional(e => e.VisitStatu)
                .HasForeignKey(e => e.Status);

            modelBuilder.Entity<Volunteer>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Volunteer>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Volunteer>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Volunteer>()
                .Property(e => e.MobilePhone)
                .IsUnicode(false);

            modelBuilder.Entity<Volunteer>()
                .Property(e => e.StreetAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Volunteer>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Volunteer>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<Volunteer>()
                .Property(e => e.Zip)
                .IsUnicode(false);

            modelBuilder.Entity<Volunteer>()
                .Property(e => e.ImageName)
                .IsUnicode(false);

            modelBuilder.Entity<Volunteer>()
                .Property(e => e.Gender)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Volunteer>()
                .Property(e => e.ParentGuardian)
                .IsUnicode(false);

            modelBuilder.Entity<Volunteer>()
                .HasMany(e => e.SurveyDistributions)
                .WithOptional(e => e.Volunteer)
                .WillCascadeOnDelete();

            modelBuilder.Entity<VolunteerCertification>()
                .Property(e => e.ImageName)
                .IsUnicode(false);

            modelBuilder.Entity<VolunteerDesignation>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<VolunteerDesignation>()
                .HasMany(e => e.VolunteerDesignation1)
                .WithOptional(e => e.VolunteerDesignation2)
                .HasForeignKey(e => e.ParentID);

            modelBuilder.Entity<VolunteerDesignation>()
                .HasMany(e => e.VolunteerJobs)
                .WithMany(e => e.VolunteerDesignations)
                .Map(m => m.ToTable("VolunteerDesignationJob").MapLeftKey("DesignationID").MapRightKey("VolunteerJobID"));

            modelBuilder.Entity<VolunteerEventCheckIn>()
                .Property(e => e.Lng)
                .IsUnicode(false);

            modelBuilder.Entity<VolunteerEventCheckIn>()
                .Property(e => e.Lat)
                .IsUnicode(false);

            modelBuilder.Entity<VolunteerGroup>()
                .HasMany(e => e.VolunteerGroupAssignments)
                .WithRequired(e => e.VolunteerGroup)
                .HasForeignKey(e => e.GroupID);

            modelBuilder.Entity<VolunteerJob>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<VolunteerJob>()
                .Property(e => e.PrivateAccessCode)
                .IsUnicode(false);

            modelBuilder.Entity<VolunteerJob>()
                .Property(e => e.WarningText)
                .IsUnicode(false);

            modelBuilder.Entity<VolunteerJob>()
                .HasMany(e => e.EmailTemplateOrganizationalUnits)
                .WithOptional(e => e.VolunteerJob)
                .HasForeignKey(e => e.VolunteerPositionID);

            modelBuilder.Entity<VolunteerJob>()
                .HasMany(e => e.VolunteerJobShifts)
                .WithRequired(e => e.VolunteerJob)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VolunteerJobGroup>()
                .HasMany(e => e.VolunteerJobs)
                .WithOptional(e => e.VolunteerJobGroup)
                .HasForeignKey(e => e.JobGroupID);

            modelBuilder.Entity<VolunteerJobShift>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<VolunteerJobShift>()
                .Property(e => e.PrivateAccessCode)
                .IsUnicode(false);

            modelBuilder.Entity<VolunteerJobShift>()
                .HasMany(e => e.EmailTemplateOrganizationalUnits)
                .WithOptional(e => e.VolunteerJobShift)
                .HasForeignKey(e => e.VolunteerShiftID);

            modelBuilder.Entity<VolunteerJobShift>()
                .HasMany(e => e.VolunteerEventCheckIns)
                .WithOptional(e => e.VolunteerJobShift)
                .HasForeignKey(e => e.ShiftID);

            modelBuilder.Entity<VolunteerJobShift>()
                .HasMany(e => e.VolunteerJobAssignments)
                .WithOptional(e => e.VolunteerJobShift)
                .HasForeignKey(e => e.JobShiftID);

            modelBuilder.Entity<Weather>()
                .Property(e => e.humidity)
                .HasPrecision(18, 1);

            modelBuilder.Entity<Weather>()
                .Property(e => e.temperature)
                .HasPrecision(18, 1);

            modelBuilder.Entity<Weather>()
                .Property(e => e.winddisplay)
                .IsUnicode(false);

            modelBuilder.Entity<Weather>()
                .Property(e => e.skytext)
                .IsUnicode(false);

            modelBuilder.Entity<vwPositionSearch>()
                .Property(e => e.JobName)
                .IsUnicode(false);

            modelBuilder.Entity<vwPositionSearch>()
                .Property(e => e.PayRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<vwPositionSearch>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<vwPositionSearch>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<vwVisit>()
                .Property(e => e.CheckInNote)
                .IsUnicode(false);

            modelBuilder.Entity<vwVisit>()
                .Property(e => e.CheckOutNote)
                .IsUnicode(false);

            modelBuilder.Entity<vwVisit>()
                .Property(e => e.BedName)
                .IsUnicode(false);

            modelBuilder.Entity<vwVisit>()
                .Property(e => e.SectionName)
                .IsUnicode(false);

            modelBuilder.Entity<vwVisit>()
                .Property(e => e.TentName)
                .IsUnicode(false);

            modelBuilder.Entity<vwVisit>()
                .Property(e => e.Lng)
                .IsUnicode(false);

            modelBuilder.Entity<vwVisit>()
                .Property(e => e.Lat)
                .IsUnicode(false);

            modelBuilder.Entity<vwVisit>()
                .Property(e => e.BIB)
                .IsUnicode(false);

            modelBuilder.Entity<vwVisit>()
                .Property(e => e.HospitalName)
                .IsUnicode(false);

            modelBuilder.Entity<vwVisit>()
                .Property(e => e.TransferredTentName)
                .IsUnicode(false);

            modelBuilder.Entity<vwVisit>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<vwVisit>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<vwVisit>()
                .Property(e => e.WristBand)
                .IsUnicode(false);

            modelBuilder.Entity<vwVisit>()
                .Property(e => e.TransportingEMSName)
                .IsUnicode(false);
        }
    }
}
