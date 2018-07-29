namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserPermissionRole")]
    public partial class UserPermissionRole
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PermissionRoleID { get; set; }

        public DateTime CreatedOn { get; set; }

        public int CreatedBy { get; set; }

        public virtual CEMUser CEMUser { get; set; }

        public virtual PermissionRole PermissionRole { get; set; }
    }
}
