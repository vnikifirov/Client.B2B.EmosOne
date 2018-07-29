namespace Emos2.Repository.Entities.Database
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Emos2.Infrastructure.Entities.DatabaseEmos1;

    public partial class Emos1Context : EntitiesContextBase
    {
        public Emos1Context()
            : base("name=Emos1Context")
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<ClientApplication> ClientApplications { get; set; }
        public virtual DbSet<ClientSetting> ClientSettings { get; set; }
        public virtual DbSet<EmailTemplateType> EmailTemplateTypes { get; set; }
        public virtual DbSet<EMOSUser> EMOSUsers { get; set; }
        public virtual DbSet<Placeholder> Placeholders { get; set; }
        public virtual DbSet<roadkill_pagecontent> roadkill_pagecontent { get; set; }
        public virtual DbSet<roadkill_pages> roadkill_pages { get; set; }
        public virtual DbSet<roadkill_siteconfiguration> roadkill_siteconfiguration { get; set; }
        public virtual DbSet<roadkill_users> roadkill_users { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<SupportTicket> SupportTickets { get; set; }
        public virtual DbSet<SupportTicketStatu> SupportTicketStatus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.WebSiteUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.LogoUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.DatabaseName)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.ServerName)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.TimeZoneInfoId)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.ClientApplications)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.ClientSettings)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.SupportTickets)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ClientApplication>()
                .Property(e => e.AppName)
                .IsUnicode(false);

            modelBuilder.Entity<ClientApplication>()
                .Property(e => e.AppLink)
                .IsUnicode(false);

            modelBuilder.Entity<ClientSetting>()
                .Property(e => e.SettingKey)
                .IsUnicode(false);

            modelBuilder.Entity<EmailTemplateType>()
                .HasMany(e => e.Placeholders)
                .WithMany(e => e.EmailTemplateTypes)
                .Map(m => m.ToTable("EmailTemplateTypePlaceholder").MapLeftKey("EmailTemplateTypeID").MapRightKey("PlaceholderID"));

            modelBuilder.Entity<Placeholder>()
                .Property(e => e.Tag)
                .IsUnicode(false);

            modelBuilder.Entity<Placeholder>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<roadkill_pages>()
                .HasMany(e => e.roadkill_pagecontent)
                .WithRequired(e => e.roadkill_pages)
                .HasForeignKey(e => e.PageId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Setting>()
                .Property(e => e.Key)
                .IsUnicode(false);

            modelBuilder.Entity<Setting>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Setting>()
                .HasMany(e => e.ClientSettings)
                .WithRequired(e => e.Setting)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SupportTicket>()
                .Property(e => e.ConatctEmail)
                .IsUnicode(false);

            modelBuilder.Entity<SupportTicket>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<SupportTicket>()
                .HasMany(e => e.SupportTicketStatus)
                .WithRequired(e => e.SupportTicket)
                .WillCascadeOnDelete(false);
        }
    }
}
