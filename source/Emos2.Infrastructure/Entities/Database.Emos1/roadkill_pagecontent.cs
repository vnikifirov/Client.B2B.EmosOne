namespace Emos2.Infrastructure.Entities.DatabaseEmos1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class roadkill_pagecontent
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(255)]
        public string EditedBy { get; set; }

        public DateTime EditedOn { get; set; }

        public int VersionNumber { get; set; }

        public string Text { get; set; }

        public int PageId { get; set; }

        public virtual roadkill_pages roadkill_pages { get; set; }
    }
}
