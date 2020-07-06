using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AgileTicketWebApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "New_Sprints",
                columns: table => new
                {
                    AgileSprintID = table.Column<string>(nullable: false),
                    AgileSprintName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_New_Sprints", x => x.AgileSprintID);
                });

            migrationBuilder.CreateTable(
                name: "New_Statuses",
                columns: table => new
                {
                    AgileStatusID = table.Column<string>(nullable: false),
                    AgileStatusName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_New_Statuses", x => x.AgileStatusID);
                });

            migrationBuilder.CreateTable(
                name: "New_Tickets",
                columns: table => new
                {
                    AgileTicketID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgileTicketName = table.Column<string>(nullable: false),
                    AgileTicketDesc = table.Column<string>(nullable: false),
                    PointValue = table.Column<int>(nullable: false),
                    Deadline = table.Column<DateTime>(nullable: false),
                    AgileSprintID = table.Column<string>(nullable: false),
                    SprintAgileSprintID = table.Column<string>(nullable: true),
                    AgileStatusID = table.Column<string>(nullable: false),
                    StatusAgileStatusID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_New_Tickets", x => x.AgileTicketID);
                    table.ForeignKey(
                        name: "FK_New_Tickets_New_Sprints_SprintAgileSprintID",
                        column: x => x.SprintAgileSprintID,
                        principalTable: "New_Sprints",
                        principalColumn: "AgileSprintID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_New_Tickets_New_Statuses_StatusAgileStatusID",
                        column: x => x.StatusAgileStatusID,
                        principalTable: "New_Statuses",
                        principalColumn: "AgileStatusID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "New_Sprints",
                columns: new[] { "AgileSprintID", "AgileSprintName" },
                values: new object[,]
                {
                    { "T-1", "Ticket-1" },
                    { "T-2", "Ticket-2" },
                    { "T-3", "Ticket-3" },
                    { "T-4", "Ticket-4" },
                    { "T-5", "Ticket-5" }
                });

            migrationBuilder.InsertData(
                table: "New_Statuses",
                columns: new[] { "AgileStatusID", "AgileStatusName" },
                values: new object[,]
                {
                    { "N", "New" },
                    { "I", "In Progress" },
                    { "Q", "Quality Assurance Review" },
                    { "C", "Complete" },
                    { "R", "Revisit" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_New_Tickets_SprintAgileSprintID",
                table: "New_Tickets",
                column: "SprintAgileSprintID");

            migrationBuilder.CreateIndex(
                name: "IX_New_Tickets_StatusAgileStatusID",
                table: "New_Tickets",
                column: "StatusAgileStatusID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "New_Tickets");

            migrationBuilder.DropTable(
                name: "New_Sprints");

            migrationBuilder.DropTable(
                name: "New_Statuses");
        }
    }
}
