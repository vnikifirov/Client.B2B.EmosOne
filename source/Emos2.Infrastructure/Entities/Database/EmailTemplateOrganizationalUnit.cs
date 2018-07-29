namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmailTemplateOrganizationalUnit")]
    public partial class EmailTemplateOrganizationalUnit
    {
        public int ID { get; set; }

        public int EmailTemplateID { get; set; }

        public int? UnitID { get; set; }

        public int? VolunteerGroupID { get; set; }

        public int? VolunteerPositionID { get; set; }

        public int? VolunteerShiftID { get; set; }

        public DateTime CreatedOn { get; set; }

        public int? VolunteerID { get; set; }

        public virtual EmailTemplate EmailTemplate { get; set; }

        public virtual OrganizationUnit OrganizationUnit { get; set; }

        public virtual VolunteerGroup VolunteerGroup { get; set; }

        public virtual VolunteerJob VolunteerJob { get; set; }

        public virtual VolunteerJobShift VolunteerJobShift { get; set; }
    }
}
