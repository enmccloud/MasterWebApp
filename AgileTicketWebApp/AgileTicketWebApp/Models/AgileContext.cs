using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AgileTicketWebApp.Models
{
    public class AgileContext : DbContext
    {
        public AgileContext(DbContextOptions<AgileContext> options)
            : base(options) { }

        public DbSet<Ticket> New_Tickets { get; set; }

        public DbSet<Sprint> New_Sprints { get; set; }

        public DbSet<Status> New_Statuses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Server=tcp:cis174enmccloud.database.windows.net,1433;Initial Catalog=CIS174enmccloud;Persist Security Info=False;User ID=enmccloud;Password=Skittles5309;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sprint>().HasData(
                new Sprint { AgileSprintID = "T-1", AgileSprintName = "Ticket-1" },
                new Sprint { AgileSprintID = "T-2", AgileSprintName = "Ticket-2" },
                new Sprint { AgileSprintID = "T-3", AgileSprintName = "Ticket-3" },
                new Sprint { AgileSprintID = "T-4", AgileSprintName = "Ticket-4" },
                new Sprint { AgileSprintID = "T-5", AgileSprintName = "Ticket-5" }
                );

            modelBuilder.Entity<Status>().HasData(
                new Status { AgileStatusID = "N", AgileStatusName = "New" },
                new Status { AgileStatusID = "I", AgileStatusName = "In Progress" },
                new Status { AgileStatusID = "Q", AgileStatusName = "Quality Assurance Review" },
                new Status { AgileStatusID = "C", AgileStatusName = "Complete" },
                new Status { AgileStatusID = "R", AgileStatusName = "Revisit" }
                );
        }
    }
}
