namespace Emos2.Infrastructure.Entities.DatabaseEmos1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class roadkill_users
    {
        public Guid Id { get; set; }

        [StringLength(255)]
        public string ActivationKey { get; set; }

        [Required]
        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(255)]
        public string Firstname { get; set; }

        [StringLength(255)]
        public string Lastname { get; set; }

        public bool IsEditor { get; set; }

        public bool IsAdmin { get; set; }

        public bool IsActivated { get; set; }

        [Required]
        [StringLength(255)]
        public string Password { get; set; }

        [StringLength(255)]
        public string PasswordResetKey { get; set; }

        [Required]
        [StringLength(255)]
        public string Salt { get; set; }

        [Required]
        [StringLength(255)]
        public string Username { get; set; }
    }
}
