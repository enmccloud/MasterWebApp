﻿// <auto-generated />
using System;
using AgileTicketWebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AgileTicketWebApp.Migrations
{
    [DbContext(typeof(AgileContext))]
    partial class AgileContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AgileTicketWebApp.Models.Sprint", b =>
                {
                    b.Property<string>("AgileSprintID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AgileSprintName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AgileSprintID");

                    b.ToTable("New_Sprints");

                    b.HasData(
                        new
                        {
                            AgileSprintID = "T-1",
                            AgileSprintName = "Ticket-1"
                        },
                        new
                        {
                            AgileSprintID = "T-2",
                            AgileSprintName = "Ticket-2"
                        },
                        new
                        {
                            AgileSprintID = "T-3",
                            AgileSprintName = "Ticket-3"
                        },
                        new
                        {
                            AgileSprintID = "T-4",
                            AgileSprintName = "Ticket-4"
                        },
                        new
                        {
                            AgileSprintID = "T-5",
                            AgileSprintName = "Ticket-5"
                        });
                });

            modelBuilder.Entity("AgileTicketWebApp.Models.Status", b =>
                {
                    b.Property<string>("AgileStatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AgileStatusName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AgileStatusID");

                    b.ToTable("New_Statuses");

                    b.HasData(
                        new
                        {
                            AgileStatusID = "N",
                            AgileStatusName = "New"
                        },
                        new
                        {
                            AgileStatusID = "I",
                            AgileStatusName = "In Progress"
                        },
                        new
                        {
                            AgileStatusID = "Q",
                            AgileStatusName = "Quality Assurance Review"
                        },
                        new
                        {
                            AgileStatusID = "C",
                            AgileStatusName = "Complete"
                        },
                        new
                        {
                            AgileStatusID = "R",
                            AgileStatusName = "Revisit"
                        });
                });

            modelBuilder.Entity("AgileTicketWebApp.Models.Ticket", b =>
                {
                    b.Property<int>("AgileTicketID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AgileSprintID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AgileStatusID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AgileTicketDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AgileTicketName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Deadline")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int>("PointValue")
                        .HasColumnType("int");

                    b.Property<string>("SprintAgileSprintID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("StatusAgileStatusID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("AgileTicketID");

                    b.HasIndex("SprintAgileSprintID");

                    b.HasIndex("StatusAgileStatusID");

                    b.ToTable("New_Tickets");
                });

            modelBuilder.Entity("AgileTicketWebApp.Models.Ticket", b =>
                {
                    b.HasOne("AgileTicketWebApp.Models.Sprint", "Sprint")
                        .WithMany()
                        .HasForeignKey("SprintAgileSprintID");

                    b.HasOne("AgileTicketWebApp.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusAgileStatusID");
                });
#pragma warning restore 612, 618
        }
    }
}