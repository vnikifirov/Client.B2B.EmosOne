namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vwPositionSearch")]
    public partial class vwPositionSearch
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int JobID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(250)]
        public string JobName { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EventID { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool Active { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SetUserLevel { get; set; }

        public int? TypeID { get; set; }

        [Column(TypeName = "money")]
        public decimal? PayRate { get; set; }

        public int? StatusID { get; set; }

        public int? CemUserID { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        public int? OrganizationUnitID { get; set; }

        [StringLength(250)]
        public string OrganizationUnitName { get; set; }

        [StringLength(500)]
        public string OrganizationUnitPath { get; set; }
    }
}
