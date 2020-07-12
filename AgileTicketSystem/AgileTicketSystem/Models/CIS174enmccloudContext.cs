using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AgileTicketSystem.Models
{
    //DB Scaffolding to create new context from database entities. 
    public partial class CIS174enmccloudContext : DbContext
    {
        public CIS174enmccloudContext()
        {
        }

        public CIS174enmccloudContext(DbContextOptions<CIS174enmccloudContext> options)
            : base(options)
        {
        }

        public virtual DbSet<RedoSprints> RedoSprints { get; set; }
        public virtual DbSet<RedoStatuses> RedoStatuses { get; set; }
        public virtual DbSet<RedoTickets> RedoTickets { get; set; }
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:cis174enmccloud.database.windows.net,1433;Initial Catalog=CIS174enmccloud;Persist Security Info=False;User ID=enmccloud;Password=Skittles5309;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RedoSprints>(entity =>
            {
                entity.HasKey(e => e.SprintId);

                entity.ToTable("Redo_Sprints");

                entity.Property(e => e.SprintId).HasColumnName("SprintID");
            });

            modelBuilder.Entity<RedoStatuses>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("Redo_Statuses");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<RedoTickets>(entity =>
            {
                entity.HasKey(e => e.TicketId);

                entity.ToTable("Redo_Tickets");

                entity.HasIndex(e => e.SprintId);

                entity.HasIndex(e => e.StatusId);

                entity.Property(e => e.TicketId).HasColumnName("TicketID");

                entity.HasOne(d => d.Sprint)
                    .WithMany(p => p.RedoTickets)
                    .HasForeignKey(d => d.SprintId);

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.RedoTickets)
                    .HasForeignKey(d => d.StatusId);
            });


            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
