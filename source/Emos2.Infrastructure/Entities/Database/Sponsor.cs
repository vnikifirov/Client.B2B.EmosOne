namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sponsor")]
    public partial class Sponsor
    {
        public int ID { get; set; }

        public int OrganizationUnitID { get; set; }

        public int? CrewRemainder { get; set; }

        public string Description { get; set; }

        public int? ManagerID { get; set; }

        [StringLength(250)]
        public string WebSite { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        [StringLength(50)]
        public string ImageName { get; set; }

        [StringLength(50)]
        public string OfficePhone { get; set; }

        public virtual OrganizationUnit OrganizationUnit { get; set; }
    }
}
