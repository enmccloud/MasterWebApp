using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AgileTicketSystem.Models
{
    //Creating my Database Context for the Tickets
    public class TicketContext : DbContext
    {
        public TicketContext(DbContextOptions<TicketContext> options)
            : base(options) { }

        public DbSet<Ticket> Redo_Tickets { get; set; }
        public DbSet<Sprint> Redo_Sprints { get; set; }

        public DbSet<Status> Redo_Statuses { get; set; }

        //Directing which database to use.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
         => options.UseSqlServer(@"Server=tcp:cis174enmccloud.database.windows.net,1433;Initial Catalog=CIS174enmccloud;Persist Security Info=False;User ID=enmccloud;Password=Skittles5309;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        //Building my table model
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sprint>().HasData(
                new Sprint { SprintID = "T-1", SprintName = "Ticket-1" },
                new Sprint { SprintID = "T-2", SprintName = "Ticket-2" },
                new Sprint { SprintID = "T-3", SprintName = "Ticket-3" },
                new Sprint { SprintID = "T-4", SprintName = "Ticket-4" },
                new Sprint { SprintID = "T-5", SprintName = "Ticket-5" }
                );

            modelBuilder.Entity<Status>().HasData(
                new Status { StatusID = "N", StatusName = "New" },
                new Status { StatusID = "I", StatusName = "In Progress" },
                new Status { StatusID = "Q", StatusName = "Quality Assurance Review" },
                new Status { StatusID = "C", StatusName = "Complete" },
                new Status { StatusID = "R", StatusName = "Revisit" }
                );
        }
    }
}
