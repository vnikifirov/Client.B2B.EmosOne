namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ItemAssignment")]
    public partial class ItemAssignment
    {
        public int ID { get; set; }

        public int ItemID { get; set; }

        public int? UniquePropertyID { get; set; }

        public int? SizeID { get; set; }

        public int AssignTo { get; set; }

        public int AuthorizeBy { get; set; }

        public DateTime AssignDate { get; set; }

        public int? LocationTo { get; set; }

        public string Note { get; set; }

        public int EventID { get; set; }

        public int? Quantity { get; set; }

        public int StatusID { get; set; }

        public int? JobID { get; set; }

        public int? OrganizationUnitID { get; set; }

        public int? TypeID { get; set; }

        public int? ItemRequestID { get; set; }

        public virtual CEMUser CEMUser { get; set; }

        public virtual CEMUser CEMUser1 { get; set; }

        public virtual Event Event { get; set; }

        public virtual Item Item { get; set; }

        public virtual ItemUniqueProperty ItemUniqueProperty { get; set; }

        public virtual Size Size { get; set; }
    }
}
