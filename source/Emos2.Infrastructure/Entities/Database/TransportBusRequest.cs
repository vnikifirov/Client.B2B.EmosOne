namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransportBusRequest")]
    public partial class TransportBusRequest
    {
        public int ID { get; set; }

        public int SiteID { get; set; }

        public int ParticipantNumber { get; set; }

        public int CoachesNumber { get; set; }

        public int AdditonalPassingerNumber { get; set; }

        public DateTime RequestOn { get; set; }

        public int? RequestBy { get; set; }

        public DateTime? ConfirmedOn { get; set; }

        public int? ConfirmedBy { get; set; }

        public int StatusID { get; set; }

        [StringLength(350)]
        public string Note { get; set; }

        public virtual CEMUser CEMUser { get; set; }

        public virtual TransportSite TransportSite { get; set; }

        public virtual TransportSiteCoordinator TransportSiteCoordinator { get; set; }
    }
}
