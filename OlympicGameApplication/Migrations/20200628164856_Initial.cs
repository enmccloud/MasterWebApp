using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OlympicGameApplication.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GameTypes",
                columns: table => new
                {
                    GameTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GameTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameTypes", x => x.GameTypeID);
                });

            migrationBuilder.CreateTable(
                name: "SettingTypes",
                columns: table => new
                {
                    Indoor_OutdoorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Indoor_OutdoorType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SettingTypes", x => x.Indoor_OutdoorID);
                });

            migrationBuilder.CreateTable(
                name: "Sports",
                columns: table => new
                {
                    SportID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SportName = table.Column<string>(nullable: true),
                    Indoor_OutdoorType = table.Column<int>(nullable: false),
                    Indoor_OutdoorID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sports", x => x.SportID);
                    table.ForeignKey(
                        name: "FK_Sports_SettingTypes_Indoor_OutdoorID",
                        column: x => x.Indoor_OutdoorID,
                        principalTable: "SettingTypes",
                        principalColumn: "Indoor_OutdoorID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CountryName = table.Column<string>(nullable: true),
                    GameTypeID = table.Column<int>(nullable: false),
                    SportID = table.Column<int>(nullable: false),
                    Indoor_OutdoorID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryID);
                    table.ForeignKey(
                        name: "FK_Countries_GameTypes_GameTypeID",
                        column: x => x.GameTypeID,
                        principalTable: "GameTypes",
                        principalColumn: "GameTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Countries_SettingTypes_Indoor_OutdoorID",
                        column: x => x.Indoor_OutdoorID,
                        principalTable: "SettingTypes",
                        principalColumn: "Indoor_OutdoorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Countries_Sports_SportID",
                        column: x => x.SportID,
                        principalTable: "Sports",
                        principalColumn: "SportID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "GameTypes",
                columns: new[] { "GameTypeID", "GameTypeName" },
                values: new object[,]
                {
                    { 1, "Paralympics" },
                    { 2, "Summer Olympics" },
                    { 3, "Winter Olympics" },
                    { 4, "Youth Olympic Games" }
                });

            migrationBuilder.InsertData(
                table: "SettingTypes",
                columns: new[] { "Indoor_OutdoorID", "Indoor_OutdoorType" },
                values: new object[,]
                {
                    { 1, "Indoor" },
                    { 2, "OutDoor" }
                });

            migrationBuilder.InsertData(
                table: "Sports",
                columns: new[] { "SportID", "Indoor_OutdoorID", "Indoor_OutdoorType", "SportName" },
                values: new object[,]
                {
                    { 1, null, 0, "Archery" },
                    { 2, null, 0, "Bobsleigh" },
                    { 3, null, 0, "Break Dancing" },
                    { 4, null, 0, "Canoe Sprint" },
                    { 5, null, 0, "Curling" },
                    { 6, null, 0, "Diving" },
                    { 7, null, 0, "Road Cycling" },
                    { 8, null, 0, "Skateboarding" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryID", "CountryName", "GameTypeID", "Indoor_OutdoorID", "SportID" },
                values: new object[,]
                {
                    { 20, "Thailand", 1, 2, 1 },
                    { 6, "Finland", 4, 2, 8 },
                    { 23, "USA", 2, 2, 7 },
                    { 14, "Netherlands", 2, 2, 7 },
                    { 2, "Brazil", 2, 2, 7 },
                    { 13, "Mexico", 2, 1, 6 },
                    { 8, "Germany", 2, 1, 6 },
                    { 4, "China", 2, 1, 6 },
                    { 19, "Sweden", 3, 1, 5 },
                    { 9, "Great Britain", 3, 1, 5 },
                    { 3, "Canada", 3, 1, 5 },
                    { 24, "Zimbabwe", 1, 2, 4 },
                    { 15, "Pakistan", 1, 2, 4 },
                    { 1, "Austria", 1, 2, 4 },
                    { 17, "Russia", 4, 1, 3 },
                    { 7, "France", 4, 1, 3 },
                    { 5, "Cyprus", 4, 1, 3 },
                    { 12, "Japan", 3, 2, 2 },
                    { 11, "Jamaica", 3, 2, 2 },
                    { 10, "Italy", 3, 2, 2 },
                    { 22, "Uruguay", 1, 2, 1 },
                    { 21, "Ukraine", 1, 2, 1 },
                    { 16, "Portugal", 4, 2, 8 },
                    { 18, "Slovakia", 4, 2, 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_GameTypeID",
                table: "Countries",
                column: "GameTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_Indoor_OutdoorID",
                table: "Countries",
                column: "Indoor_OutdoorID");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_SportID",
                table: "Countries",
                column: "SportID");

            migrationBuilder.CreateIndex(
                name: "IX_Sports_Indoor_OutdoorID",
                table: "Sports",
                column: "Indoor_OutdoorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "GameTypes");

            migrationBuilder.DropTable(
                name: "Sports");

            migrationBuilder.DropTable(
                name: "SettingTypes");
        }
    }
}
