namespace ChrisPOC
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<USER> USERS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<USER>()
                .Property(e => e.UUID)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.SHUTDOWN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.SHUTDOWN_COMPLETE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.ACTIVE)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.SESSION_ID)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.LOCAL_REPORTS)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.SECTOR)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.RECORD_STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.FK_HCP_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.FK_STAFF_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.FK_LOCATION_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.ACL)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.SSO)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.PASSWORD_LAST_AMENDED_BY)
                .IsUnicode(false);
        }
    }
}
