using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactListApplication.Migrations
{
    public partial class InitialContactDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    StateAbbr = table.Column<string>(nullable: false),
                    ZipCode = table.Column<int>(nullable: false),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "Address", "City", "Name", "Note", "PhoneNumber", "StateAbbr", "ZipCode" },
                values: new object[] { 1, "309 Arthur Neu Dr.", "Carroll", "Nikki McCloud", "Myself.", "712-210-5283", "IA", 51401 });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "Address", "City", "Name", "Note", "PhoneNumber", "StateAbbr", "ZipCode" },
                values: new object[] { 2, "309 Arthur Neu Dr.", "Carroll", "Jon Campbell", "Fiance", "712-830-5158", "IA", 51401 });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "Address", "City", "Name", "Note", "PhoneNumber", "StateAbbr", "ZipCode" },
                values: new object[] { 3, "369 Troy Dr.", "Los Angeles", "Jason Sudekis", "Famous Celebrity", "555-555-5555", "CA", 90001 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
