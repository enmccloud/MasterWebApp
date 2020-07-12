using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AgileTicketSystem.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Redo_Sprints",
                columns: table => new
                {
                    SprintID = table.Column<string>(nullable: false),
                    SprintName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Redo_Sprints", x => x.SprintID);
                });

            migrationBuilder.CreateTable(
                name: "Redo_Statuses",
                columns: table => new
                {
                    StatusID = table.Column<string>(nullable: false),
                    StatusName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Redo_Statuses", x => x.StatusID);
                });

            migrationBuilder.CreateTable(
                name: "Redo_Tickets",
                columns: table => new
                {
                    TicketID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicketName = table.Column<string>(nullable: true),
                    TicketDesc = table.Column<string>(nullable: true),
                    Deadline = table.Column<DateTime>(nullable: true),
                    PointValue = table.Column<int>(nullable: false),
                    SprintId = table.Column<string>(nullable: true),
                    StatusId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Redo_Tickets", x => x.TicketID);
                    table.ForeignKey(
                        name: "FK_Redo_Tickets_Redo_Sprints_SprintId",
                        column: x => x.SprintId,
                        principalTable: "Redo_Sprints",
                        principalColumn: "SprintID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Redo_Tickets_Redo_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Redo_Statuses",
                        principalColumn: "StatusID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Redo_Sprints",
                columns: new[] { "SprintID", "SprintName" },
                values: new object[,]
                {
                    { "T-1", "Ticket-1" },
                    { "T-2", "Ticket-2" },
                    { "T-3", "Ticket-3" },
                    { "T-4", "Ticket-4" },
                    { "T-5", "Ticket-5" }
                });

            migrationBuilder.InsertData(
                table: "Redo_Statuses",
                columns: new[] { "StatusID", "StatusName" },
                values: new object[,]
                {
                    { "N", "New" },
                    { "I", "In Progress" },
                    { "Q", "Quality Assurance Review" },
                    { "C", "Complete" },
                    { "R", "Revisit" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Redo_Tickets_SprintId",
                table: "Redo_Tickets",
                column: "SprintId");

            migrationBuilder.CreateIndex(
                name: "IX_Redo_Tickets_StatusId",
                table: "Redo_Tickets",
                column: "StatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Redo_Tickets");

            migrationBuilder.DropTable(
                name: "Redo_Sprints");

            migrationBuilder.DropTable(
                name: "Redo_Statuses");
        }
    }
}
