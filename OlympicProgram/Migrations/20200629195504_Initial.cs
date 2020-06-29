using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OlympicProgram.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OlyCats",
                columns: table => new
                {
                    OlyCatID = table.Column<string>(nullable: false),
                    OlyCatName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OlyCats", x => x.OlyCatID);
                });

            migrationBuilder.CreateTable(
                name: "OlyGames",
                columns: table => new
                {
                    OlyGameID = table.Column<string>(nullable: false),
                    OlyGameName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OlyGames", x => x.OlyGameID);
                });

            migrationBuilder.CreateTable(
                name: "OlySports",
                columns: table => new
                {
                    OlySportID = table.Column<string>(nullable: false),
                    OlySportName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OlySports", x => x.OlySportID);
                });

            migrationBuilder.CreateTable(
                name: "OlyCountries",
                columns: table => new
                {
                    OlyCountryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OlyCountryName = table.Column<string>(nullable: true),
                    OlyCountryFlag = table.Column<string>(nullable: true),
                    OlyCatID = table.Column<string>(nullable: true),
                    OlyGameID = table.Column<string>(nullable: true),
                    OlySportID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OlyCountries", x => x.OlyCountryID);
                    table.ForeignKey(
                        name: "FK_OlyCountries_OlyCats_OlyCatID",
                        column: x => x.OlyCatID,
                        principalTable: "OlyCats",
                        principalColumn: "OlyCatID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OlyCountries_OlyGames_OlyGameID",
                        column: x => x.OlyGameID,
                        principalTable: "OlyGames",
                        principalColumn: "OlyGameID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OlyCountries_OlySports_OlySportID",
                        column: x => x.OlySportID,
                        principalTable: "OlySports",
                        principalColumn: "OlySportID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "OlyCats",
                columns: new[] { "OlyCatID", "OlyCatName" },
                values: new object[,]
                {
                    { "I", "Indoor" },
                    { "O", "OutDoor" }
                });

            migrationBuilder.InsertData(
                table: "OlyGames",
                columns: new[] { "OlyGameID", "OlyGameName" },
                values: new object[,]
                {
                    { "P", "Paralympics" },
                    { "S", "Summer Olympics" },
                    { "W", "Winter Olympics" },
                    { "Y", "Youth Olympic Games" }
                });

            migrationBuilder.InsertData(
                table: "OlySports",
                columns: new[] { "OlySportID", "OlySportName" },
                values: new object[,]
                {
                    { "A", "Archery" },
                    { "B", "Bobsleigh" },
                    { "BD", "Breakdancing" },
                    { "CS", "Canoe Sprint" },
                    { "C", "Curling" },
                    { "D", "Diving" },
                    { "RC", "Road Cycling" },
                    { "S", "Skateboarding" }
                });

            migrationBuilder.InsertData(
                table: "OlyCountries",
                columns: new[] { "OlyCountryID", "OlyCatID", "OlyCountryFlag", "OlyCountryName", "OlyGameID", "OlySportID" },
                values: new object[,]
                {
                    { 20, "O", "Thailand.png", "Thailand", "P", "A" },
                    { 6, "O", "Finland.png", "Finland", "Y", "S" },
                    { 23, "O", "USA.png", "USA", "S", "RC" },
                    { 14, "O", "Netherlands.png", "Netherlands", "S", "RC" },
                    { 2, "O", "Brazil.png", "Brazil", "S", "RC" },
                    { 13, "I", "Mexico.png", "Mexico", "S", "D" },
                    { 8, "I", "Germany.png", "Germany", "S", "D" },
                    { 4, "I", "China.png", "China", "S", "D" },
                    { 19, "I", "Sweden.png", "Sweden", "W", "C" },
                    { 9, "I", "Great Britain.png", "Great Britain", "W", "C" },
                    { 3, "I", "Canada.png", "Canada", "W", "C" },
                    { 24, "O", "Zimbabwe.png", "Zimbabwe", "P", "CS" },
                    { 15, "O", "Pakistan.png", "Pakistan", "P", "CS" },
                    { 1, "O", "Austria.png", "Austria", "P", "CS" },
                    { 17, "I", "Russia.png", "Russia", "Y", "BD" },
                    { 7, "I", "France.png", "France", "Y", "BD" },
                    { 5, "I", "Cyprus.png", "Cyprus", "Y", "BD" },
                    { 12, "O", "Japan.png", "Japan", "W", "B" },
                    { 11, "O", "Jamaica.png", "Jamaica", "W", "B" },
                    { 10, "O", "Italy.png", "Italy", "W", "B" },
                    { 22, "O", "Uruguay.png", "Uruguay", "P", "A" },
                    { 21, "O", "Ukraine.png", "Ukraine", "P", "A" },
                    { 16, "O", "Portugal.png", "Portugal", "Y", "S" },
                    { 18, "O", "Slovakia.png", "Slovakia", "Y", "S" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OlyCountries_OlyCatID",
                table: "OlyCountries",
                column: "OlyCatID");

            migrationBuilder.CreateIndex(
                name: "IX_OlyCountries_OlyGameID",
                table: "OlyCountries",
                column: "OlyGameID");

            migrationBuilder.CreateIndex(
                name: "IX_OlyCountries_OlySportID",
                table: "OlyCountries",
                column: "OlySportID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OlyCountries");

            migrationBuilder.DropTable(
                name: "OlyCats");

            migrationBuilder.DropTable(
                name: "OlyGames");

            migrationBuilder.DropTable(
                name: "OlySports");
        }
    }
}
