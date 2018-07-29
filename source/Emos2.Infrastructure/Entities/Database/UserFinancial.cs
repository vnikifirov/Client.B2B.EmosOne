namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserFinancial")]
    public partial class UserFinancial
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EventID { get; set; }

        public int? W9 { get; set; }

        public DateTime? Requisition { get; set; }

        public DateTime? PackingList { get; set; }

        public DateTime? Paid { get; set; }

        public DateTime SetOn { get; set; }

        public int? SetBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        [StringLength(250)]
        public string PayTo { get; set; }

        public DateTime? Approved { get; set; }

        [StringLength(250)]
        public string Expenses { get; set; }

        public virtual CEMUser CEMUser { get; set; }

        public virtual Event Event { get; set; }
    }
}
