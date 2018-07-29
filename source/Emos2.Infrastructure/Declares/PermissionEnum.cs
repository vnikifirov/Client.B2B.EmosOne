using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emos2.Infrastructure.Declares
{
    public enum PermissionsGroup
    {

        Job = 10,
        [Description("_general_Hotel_Airfare_")]
        Hotel_Airfare_Parking = 21,
        // <Description("Hotel & Airfare")> Hotel_Airfare_Parking = 21
        Messaging = 50,
        Reporting = 60,
        [Description("general_Volunteers")]
        VOLUNTEERS = 80,
        // <Description("Volunteers")> VOLUNTEERS = 80
        [Description("general_Timeline")]
        TIMELINE = 120,
        // <Description("Timeline")> TIMELINE = 120
        [Description("_systemActions_Survey")]
        SURVEY = 130,
        // <Description("Survey")> SURVEY = 130
        [Description("general_Transportation")]
        TRANSPORTATION = 180,
        // <Description("Transportation")> TRANSPORTATION = 180
        [Description("general_Inventory")]
        INVENTORY = 190,
        // <Description("Inventory")> INVENTORY = 190
        [Description("_systemActions_Personnel")]
        Personnel = 200,
        // <Description("Personnel")> Personnel = 200
        MPTS = 1000

    }

    public enum Permission
    {
        [Description("_systemActions_CanCreateJob_")]
        CAN_CREATE_JOB = 1,
        // <Description("Can Create Job?")> CAN_CREATE_JOB = 1
        [Description("_systemActions_CanConfirmJob_")]
        CAN_CONFIRM_JOB = 2,
        // <Description("Can Confirm Job?")> CAN_CONFIRM_JOB = 2
        [Description("_systemActions_CanSeePayRate_")]
        CAN_SEE_PAY_RATE = 20,
        // <Description("Can See Pay Rate?")> CAN_SEE_PAY_RATE = 20

        [Description("_systemActions_CanRequestHotel_")]
        CAN_REQUEST_HOTEL = 50,
        // <Description("Can Request Hotel?")> CAN_REQUEST_HOTEL = 50
        [Description("_systemActions_CanApproveHotel_")]
        CAN_APPROVE_HOTEL = 51,
        // <Description("Can Approve Hotel?")> CAN_APPROVE_HOTEL = 51
        [Description("_systemActions_CanBookHotel_")]
        CAN_BOOK_HOTEL = 52,
        // <Description("Can Book Hotel?")> CAN_BOOK_HOTEL = 52
        [Description("_systemActions_CanConfirmHotelBooking_")]
        CAN_CONFIRM_HOTEL_BOOKING = 53,
        // <Description("Can Confirm Hotel Booking?")> CAN_CONFIRM_HOTEL_BOOKING = 53
        [Description("_systemActions_CanDeleteHotelRequest_")]
        CAN_DELETE_HOTEL_REQUEST = 54,

        [Description("_systemActions_CanRequestAirfare_")]
        CAN_REQUEST_AIRFARE = 60,
        [Description("_systemActions_CanApproveAirfare_")]
        CAN_APPROVE_AIRFARE = 61,
        [Description("_systemActions_CanBookAirfare_")]
        CAN_BOOK_AIRFARE = 62,
        [Description("_systemActions_CanConfirmAirfareBooking_")]
        CAN_CONFIRM_AIRFARE_BOOKING = 63,
        [Description("_systemActions_CanDeleteAirfareRequest_")]
        CAN_DELETE_AIRFARE_REQUEST = 64,

        //'  <Description("Can Request Parking?")> CAN_REQUEST_PARKING = 70
        //'   <Description("Can Approve Parking?")> CAN_APPROVE_PARKING = 71
        //'  <Description("Can Book Parking?")> CAN_BOOK_PARKING = 72
        //'   <Description("Can Confirm Parking Booking?")> CAN_CONFIRM_PARKING_BOOKING = 73

        [Description("_systemActions_CanSendEmails_")]
        CAN_SEND_EMAILS = 80,
        [Description("_systemActions_CanSendTextMessages_")]
        CAN_SEND_SMS = 81,
        [Description("_systemActions_CanSendMessages2All_")]
        CAN_SEND_MESSAGES_TO_ALL = 82,
        [Description("_systemActions_CanSendMessages2Staff_")]
        CAN_SEND_MESSAGES_TO_STAFF = 83,
        [Description("_systemActions_CanSendMessages2Volunteers_")]
        CAN_SEND_MESSAGES_TO_VOLUNTEERS = 84,
        [Description("_systemActions_CanSendMessages2Participant_")]
        CAN_SEND_MESSAGES_TO_PARTICIPANT = 85,


        [Description("_systemActions_CanExportHotelAirfareParking_")]
        CAN_EXPORT_PREREQUISITES = 90,
        [Description("_systemActions_CanExportMerchandise_")]
        CAN_EXPORT_MERCHANDISE = 91,
        [Description("_systemActions_CanExportFinancial_")]
        CAN_EXPORT_FINANCIAL = 92,
        [Description("_systemActions_CanExportCredentials_")]
        CAN_EXPORT_CREDENTIALS = 93,
        [Description("_systemActions_CanExportInventory_")]
        CAN_EXPORT_INVENTORY = 94,


        [Description("_systemActions_CanSearchParticipants_")]
        SEARCH_PARTICIPANT = 1010,
        [Description("_systemActions_CanSearchPatients_")]
        SEARCH_PATIENT = 1011,
        [Description("_systemActions_CanSearchFastTrack_")]
        SEARCH_FASTTRACK = 1070,
        [Description("_systemActions_RunnerTransportServiceCheckIn_")]
        RUNNER_TRENSPORT_SERVICE_CHECK_IN = 1020,
        [Description("_systemActions_EMS_VehicleCheckIn")]
        EMS_VEHICLE_CHECK_IN = 1030,
        [Description("_systemActions_EMS_VehicleAdministration_")]
        EMS_VEHICLES_ADMIN = 1031,
        [Description("_systemActions_MedicalUnits_tent_aid_station_checkin")]
        MEDICAL_TENT_CHEKC_IN = 1040,
        [Description("_systemActions_CanReadPatientMedicalRecord_")]
        CAN_READ_PATIENT_MEDICAL_INFO = 1045,
        [Description("_systemActions_FastTrackCheckin")]
        FAST_TRACK_CHECK_IN = 1050,
        [Description("_systemActions_AthleteCheckin")]
        ATHLETE_CHECK_IN = 1060,
        [Description("_systemActions_CanSetMPTSrace_")]
        SET_MPTS_RACE = 1061,
        [Description("_systemActions_CanSendPushNotifications_commands_")]
        SEND_PUSH_NOTIFICATION = 1062,
        [Description("_systemActions_CanSetCheckinLocation_")]
        SET_CHECK_IN_LOCATION = 1063,
        [Description("_systemActions_CanSeeMPTSsummaries_")]
        CAN_SEE_MPTS_SUMMARIES = 1064,
        [Description("_systemActions_CanAaccessAllMPTSunits_")]
        CAN_ACCESS_ALL_MPTS_UNITS = 1065,
        [Description("_systemActions_CanEditMPTSpatientVisit_")]
        CAN_EDIT_MPTS_VISIT = 1066,
        [Description("_systemActions_CanManageMPTSadministration_")]
        CAN_MANAGE_MPTS_ADMINISTRATION = 1067,


        [Description("_systemActions_CanManageTimeline_")]
        CAN_MANAGE_TIMELINE = 110,
        [Description("_systemActions_CanCreateTimelineActivity_")]
        CAN_CREATE_TIMELINE = 112,
        [Description("_systemActions_CanExportTimeline_")]
        CAN_EXPORT_TIMELINE = 113,
        [Description("_systemActions_CanSeeWholeTimeline_")]
        CAN_SEE_ALL_TIMELINE = 114,

        [Description("_systemActions_CanCreateSurvey_")]
        CAN_CREATE_SURVEY = 120,
        [Description("_systemActions_CanManageSurvey_")]
        CAN_MANAGE_SURVEY = 121,

        [Description("_systemActions_CanManageSeeAllStaff_")]
        CAN_MANAGE_EVENT_STAFF = 130,
        [Description("_systemActions_CanSearchStaff_")]
        CAN_SEARCH_EVENT_STAFF = 131,
        [Description("_systemActions_CanManageHotelAirfareParking_")]
        CAN_MANAGE_TRAVELLING = 132,
        [Description("_systemActions_CanManageSeeAllEliteAthletes_")]
        CAN_MANAGE_PARTICIPANT = 133,
        [Description("_systemActions_CanManageSeeAllRaceManagement_")]
        CAN_MANAGE_VIP = 134,
        [Description("_systemActions_CanManageAeeAllForwardCommand_")]
        CAN_MANAGE_FORWARD_COMMAND = 135,
        [Description("_systemActions_CanManageSeeAllOfficeStaff_")]
        CAN_MANAGE_OFFICE_STAFF = 136,

        [Description("_systemActions_CanManageSeeCharity_")]
        CAN_MANAGE_CHARITY = 140,
        //<Description("Can create charity?")> CAN_CREATE_CHARITY = 141
        [Description("_systemActions_CanManageSeeAllExhibitors_")]
        CAN_MANAGE_EXHIBITOR = 150,
        //<Description("Can create exhibitor?")> CAN_CREATE_EXHIBITOR = 151
        [Description("_systemActions_CanManageSeeAllVendors_")]
        CAN_MANAGE_VENDOR = 160,
        //<Description("Can create vendor?")> CAN_CREATE_VENDOR = 161
        [Description("_systemActions_CanManageSeeAllSponsors_")]
        CAN_MANAGE_SPONSOR = 170,
        //<Description("Can create sponsor?")> CAN_CREATE_SPONSOR = 171
        [Description("_systemActions_CanManageSeeMedia_")]
        CAN_MANAGE_MEDIA = 175,

        [Description("_systemActions_CanManageSeeAllVolunteers_")]
        CAN_MANAGE_VOLUNTEERS = 180,
        [Description("_systemActions_CanSearchVolunteers_")]
        CAN_SEARCH_VOLUNTEERS = 181,
        //' <Description("Can approve volunteer groups?")> CAN_APPROVE_GROUPS = 182
        [Description("_systemActions_CanConfirmPositionApplication_")]
        CAN_CONFIRM_POSITION_APPLICATION = 183,
        [Description("_systemActions_CanCheckinVolunteers_")]
        CAN_CHECKIN_VOLUNTEERS = 184,
        [Description("_systemActions_CanCheckMedicalLicense_")]
        CAN_CHECK_VOLUNTEER_MEDICAL_LICENSE = 185,
        [Description("_systemActions_CanCreateVolunteerPosition_")]
        CAN_CREATE_EDIT_VOLUNTEER_POSITION = 186,
        [Description("_systemActions_CanCreateVolunteerGroup_")]
        CAN_CREATE_VOLUNTEER_GROUP = 187,
        [Description("_systemActions_CanCreateVolunteerShift_")]
        CAN_CREATE_EDIT_VOLUNTEER_SHIFT = 188,


        [Description("_systemActions_CanSearchParticipant_")]
        CAN_SEARCH_PARTICIPANT = 190,
        [Description("_systemActions_CanManageTransportation_")]
        CAN_MANAGE_TRANSPORTATION = 200,
        [Description("_systemActions_CanCheckinEventStaff_")]
        CAN_CHECKIN_EVENT_STAFF = 300,
        [Description("_systemActions_CanCheckinExhibitors_")]
        CAN_CHECKIN_EXHIBITORS = 301,
        [Description("_systemActions_CanCheckinRaceManagement")]
        CAN_CHECKIN_RACE_MANAGEMENT = 302,


        [Description("_systemActions_CanConfrim_rejectRequestedItems")]
        CAN_CONFIRM_REQUESTED_ITEMS = 400,
        [Description("_systemActions_CanConfrimRequestedVehicles")]
        CAN_CONFIRM_REQUESTED_VEHICLES = 401,
        [Description("_systemActions_CanManageVehicles")]
        CAN_MANAGE_VEHICLES = 402,
        [Description("CAN MANAGE WHOLE INVENTORY")]
        CAN_MANAGE_WHOLE_INVENTORY = 403,
        [Description("_systemActions_CanAddAndValidateCredentials")]
        CAN_ADD_AND_VALIDATE_CREDENTIALS = 405,
        [Description("Can manage equipment")]
        CAN_MANAGE_EQUIPMENT = 407,
        [Description("Can manage radios")]
        CAN_MANAGE_RADIOS = 409,
        [Description("Can see equipment lists")]
        CAN_SEE_EQUIPMENT_LISTS = 411,
        [Description("Can manage storage")]
        CAN_MANAGE_STORAGES = 413,
        [Description("Can manage equipment setup")]
        CAN_MANAGE_EQUIPMENT_SETUP = 415,

        [Description("_systemActions_CanSeeSameLevelLoginLink_")]
        CAN_SEE_SAME_LEVEL_LOGIN_LINK = 210,
        [Description("_systemActions_CanEditTeamPersonalInfo_")]
        CAN_EDIT_TEAM_PERSONAL_INFO = 220,

        [Description("_systemActions_CanToggleEvents_")]
        CAN_TOGGLE_BETWEEN_EVENTS = 221

    }


    public static class Permissions
    {



        public static List<Permission> GetSystemActions(this PermissionsGroup @group)
        {
            List<Permission> list = new List<Permission>();
            switch (@group)
            {
                case PermissionsGroup.Job:
                    list.Add(Permission.CAN_CREATE_JOB);
                    list.Add(Permission.CAN_CONFIRM_JOB);
                    list.Add(Permission.CAN_SEE_PAY_RATE);

                    break;
                case PermissionsGroup.Hotel_Airfare_Parking:
                    list.Add(Permission.CAN_MANAGE_TRAVELLING);
                    list.Add(Permission.CAN_REQUEST_HOTEL);
                    list.Add(Permission.CAN_APPROVE_HOTEL);
                    list.Add(Permission.CAN_BOOK_HOTEL);
                    list.Add(Permission.CAN_CONFIRM_HOTEL_BOOKING);
                    list.Add(Permission.CAN_DELETE_HOTEL_REQUEST);

                    list.Add(Permission.CAN_REQUEST_AIRFARE);
                    list.Add(Permission.CAN_APPROVE_AIRFARE);
                    list.Add(Permission.CAN_BOOK_AIRFARE);
                    list.Add(Permission.CAN_CONFIRM_AIRFARE_BOOKING);
                    list.Add(Permission.CAN_DELETE_AIRFARE_REQUEST);

                    break;
                case PermissionsGroup.Messaging:
                    list.Add(Permission.CAN_SEND_EMAILS);
                    list.Add(Permission.CAN_SEND_SMS);
                    list.Add(Permission.CAN_SEND_MESSAGES_TO_ALL);
                    list.Add(Permission.CAN_SEND_MESSAGES_TO_STAFF);
                    list.Add(Permission.CAN_SEND_MESSAGES_TO_VOLUNTEERS);
                    list.Add(Permission.CAN_SEND_MESSAGES_TO_PARTICIPANT);

                    break;

                case PermissionsGroup.Reporting:
                    list.Add(Permission.CAN_EXPORT_PREREQUISITES);
                    list.Add(Permission.CAN_EXPORT_MERCHANDISE);
                    list.Add(Permission.CAN_EXPORT_FINANCIAL);
                    list.Add(Permission.CAN_EXPORT_TIMELINE);
                    list.Add(Permission.CAN_EXPORT_CREDENTIALS);
                    list.Add(Permission.CAN_EXPORT_INVENTORY);

                    break;
                case PermissionsGroup.MPTS:
                    list.Add(Permission.SEARCH_PARTICIPANT);
                    list.Add(Permission.SEARCH_PATIENT);
                    list.Add(Permission.SEARCH_FASTTRACK);
                    list.Add(Permission.RUNNER_TRENSPORT_SERVICE_CHECK_IN);
                    list.Add(Permission.EMS_VEHICLE_CHECK_IN);
                    list.Add(Permission.EMS_VEHICLES_ADMIN);
                    list.Add(Permission.MEDICAL_TENT_CHEKC_IN);
                    list.Add(Permission.FAST_TRACK_CHECK_IN);
                    list.Add(Permission.ATHLETE_CHECK_IN);
                    list.Add(Permission.CAN_READ_PATIENT_MEDICAL_INFO);
                    list.Add(Permission.SET_MPTS_RACE);
                    list.Add(Permission.SEND_PUSH_NOTIFICATION);
                    list.Add(Permission.SET_CHECK_IN_LOCATION);
                    list.Add(Permission.CAN_SEE_MPTS_SUMMARIES);
                    list.Add(Permission.CAN_ACCESS_ALL_MPTS_UNITS);
                    list.Add(Permission.CAN_EDIT_MPTS_VISIT);
                    list.Add(Permission.CAN_MANAGE_MPTS_ADMINISTRATION);

                    break;

                //Case SystemActionGroupList.MERCHANDISE
                //    list.Add(Permission.CAN_MANAGE_MERCHANDISE)


                case PermissionsGroup.SURVEY:
                    list.Add(Permission.CAN_MANAGE_SURVEY);
                    list.Add(Permission.CAN_CREATE_SURVEY);

                    break;
                case PermissionsGroup.TIMELINE:
                    list.Add(Permission.CAN_MANAGE_TIMELINE);
                    list.Add(Permission.CAN_CREATE_TIMELINE);
                    list.Add(Permission.CAN_SEE_ALL_TIMELINE);

                    break;

                case PermissionsGroup.VOLUNTEERS:
                    list.Add(Permission.CAN_SEARCH_VOLUNTEERS);
                    list.Add(Permission.CAN_MANAGE_VOLUNTEERS);
                    list.Add(Permission.CAN_CHECKIN_VOLUNTEERS);
                    list.Add(Permission.CAN_CONFIRM_POSITION_APPLICATION);
                    list.Add(Permission.CAN_CHECK_VOLUNTEER_MEDICAL_LICENSE);
                    list.Add(Permission.CAN_CREATE_EDIT_VOLUNTEER_POSITION);
                    list.Add(Permission.CAN_CREATE_EDIT_VOLUNTEER_SHIFT);
                    list.Add(Permission.CAN_CREATE_VOLUNTEER_GROUP);

                    break;
                case PermissionsGroup.TRANSPORTATION:
                    list.Add(Permission.CAN_MANAGE_TRANSPORTATION);
                    break;
                //' Case SystemActionGroupList.CHECK_iN

                case PermissionsGroup.INVENTORY:
                    list.Add(Permission.CAN_MANAGE_WHOLE_INVENTORY);
                    list.Add(Permission.CAN_MANAGE_EQUIPMENT);
                    list.Add(Permission.CAN_MANAGE_RADIOS);
                    list.Add(Permission.CAN_SEE_EQUIPMENT_LISTS);
                    list.Add(Permission.CAN_MANAGE_STORAGES);
                    list.Add(Permission.CAN_MANAGE_EQUIPMENT_SETUP);

                    list.Add(Permission.CAN_MANAGE_VEHICLES);
                    list.Add(Permission.CAN_CONFIRM_REQUESTED_ITEMS);
                    list.Add(Permission.CAN_CONFIRM_REQUESTED_VEHICLES);
                    list.Add(Permission.CAN_ADD_AND_VALIDATE_CREDENTIALS);

                    break;

                case PermissionsGroup.Personnel:
                    list.Add(Permission.CAN_CHECKIN_EVENT_STAFF);
                    list.Add(Permission.CAN_CHECKIN_EXHIBITORS);
                    list.Add(Permission.CAN_CHECKIN_RACE_MANAGEMENT);
                    list.Add(Permission.CAN_SEARCH_EVENT_STAFF);
                    list.Add(Permission.CAN_SEARCH_PARTICIPANT);
                    list.Add(Permission.CAN_MANAGE_EVENT_STAFF);
                    list.Add(Permission.CAN_MANAGE_OFFICE_STAFF);
                    list.Add(Permission.CAN_MANAGE_FORWARD_COMMAND);
                    list.Add(Permission.CAN_MANAGE_EXHIBITOR);
                    list.Add(Permission.CAN_MANAGE_VENDOR);
                    list.Add(Permission.CAN_MANAGE_SPONSOR);
                    list.Add(Permission.CAN_MANAGE_CHARITY);
                    list.Add(Permission.CAN_MANAGE_PARTICIPANT);
                    list.Add(Permission.CAN_MANAGE_VIP);
                    list.Add(Permission.CAN_MANAGE_MEDIA);
                    list.Add(Permission.CAN_SEE_SAME_LEVEL_LOGIN_LINK);
                    list.Add(Permission.CAN_EDIT_TEAM_PERSONAL_INFO);
                    list.Add(Permission.CAN_TOGGLE_BETWEEN_EVENTS);

                    break;
            }

            return list;

        }

    }
}
