namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserOrganizationUnit")]
    public partial class UserOrganizationUnit
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrganizationUnitID { get; set; }

        public int? UserLevelID { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public virtual CEMUser CEMUser { get; set; }

        public virtual OrganizationUnit OrganizationUnit { get; set; }
    }
}
