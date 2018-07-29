namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EventEmailServiceAccount")]
    public partial class EventEmailServiceAccount
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EventID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmailServiceAccountID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TypeID { get; set; }

        [Required]
        [StringLength(250)]
        public string DisplayName { get; set; }

        [Required]
        [StringLength(250)]
        public string ReplyTo { get; set; }

        public virtual EmailServiceAccount EmailServiceAccount { get; set; }

        public virtual Event Event { get; set; }
    }
}
