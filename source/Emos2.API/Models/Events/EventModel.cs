using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emos2.API.Models.Events
{
    public class EventModel
    {
        public string ID { get; set; }
        
        public string Name { get; set; }
        public string Description { get; set; }
        public string EventStart { get; set; }
        public string EventEnd { get; set; }
        public string StartRegistration { get; set; }
        public string EndRegistration { get; set; }
        public string Location { get; set; }
        public string Lng { get; set; }
        public string Lat { get; set; }
        public string StatusID { get; set; }
        public string LogoImage { get; set; }
        public string TimeZoneInfoId { get; set; }
        public string Waiver { get; set; }
        public string HeaderImage { get; set; }
        public string ConfidentialityAgreement { get; set; }
        public string Abbreviation { get; set; }

    }
}