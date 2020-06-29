using Microsoft.EntityFrameworkCore.Migrations;

namespace OlympicGameApplication.Migrations
{
    public partial class Redo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_SettingTypes_Indoor_OutdoorID",
                table: "Countries");

            migrationBuilder.DropForeignKey(
                name: "FK_Sports_SettingTypes_Indoor_OutdoorID",
                table: "Sports");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SettingTypes",
                table: "SettingTypes");

            migrationBuilder.RenameTable(
                name: "SettingTypes",
                newName: "IndoorOutdoorTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IndoorOutdoorTypes",
                table: "IndoorOutdoorTypes",
                column: "Indoor_OutdoorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_IndoorOutdoorTypes_Indoor_OutdoorID",
                table: "Countries",
                column: "Indoor_OutdoorID",
                principalTable: "IndoorOutdoorTypes",
                principalColumn: "Indoor_OutdoorID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sports_IndoorOutdoorTypes_Indoor_OutdoorID",
                table: "Sports",
                column: "Indoor_OutdoorID",
                principalTable: "IndoorOutdoorTypes",
                principalColumn: "Indoor_OutdoorID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_IndoorOutdoorTypes_Indoor_OutdoorID",
                table: "Countries");

            migrationBuilder.DropForeignKey(
                name: "FK_Sports_IndoorOutdoorTypes_Indoor_OutdoorID",
                table: "Sports");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IndoorOutdoorTypes",
                table: "IndoorOutdoorTypes");

            migrationBuilder.RenameTable(
                name: "IndoorOutdoorTypes",
                newName: "SettingTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SettingTypes",
                table: "SettingTypes",
                column: "Indoor_OutdoorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_SettingTypes_Indoor_OutdoorID",
                table: "Countries",
                column: "Indoor_OutdoorID",
                principalTable: "SettingTypes",
                principalColumn: "Indoor_OutdoorID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sports_SettingTypes_Indoor_OutdoorID",
                table: "Sports",
                column: "Indoor_OutdoorID",
                principalTable: "SettingTypes",
                principalColumn: "Indoor_OutdoorID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
