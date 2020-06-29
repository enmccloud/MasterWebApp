﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OlympicProgram.Models;

namespace OlympicProgram.Migrations
{
    [DbContext(typeof(OlyContext))]
    [Migration("20200629215141_Again")]
    partial class Again
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OlympicProgram.Models.OlyCat", b =>
                {
                    b.Property<string>("OlyCatID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("OlyCatName");

                    b.HasKey("OlyCatID");

                    b.ToTable("OlyCats");

                    b.HasData(
                        new { OlyCatID = "I", OlyCatName = "Indoor" },
                        new { OlyCatID = "O", OlyCatName = "OutDoor" }
                    );
                });

            modelBuilder.Entity("OlympicProgram.Models.OlyCountry", b =>
                {
                    b.Property<int>("OlyCountryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OlyCatID");

                    b.Property<string>("OlyCountryFlag");

                    b.Property<string>("OlyCountryName");

                    b.Property<string>("OlyGameID");

                    b.Property<string>("OlySportID");

                    b.HasKey("OlyCountryID");

                    b.HasIndex("OlyCatID");

                    b.HasIndex("OlyGameID");

                    b.HasIndex("OlySportID");

                    b.ToTable("OlyCountries");

                    b.HasData(
                        new { OlyCountryID = 1, OlyCatID = "O", OlyCountryFlag = "Austria.png", OlyCountryName = "Austria", OlyGameID = "P", OlySportID = "CS" },
                        new { OlyCountryID = 2, OlyCatID = "O", OlyCountryFlag = "Brazil.png", OlyCountryName = "Brazil", OlyGameID = "S", OlySportID = "RC" },
                        new { OlyCountryID = 3, OlyCatID = "I", OlyCountryFlag = "Canada.png", OlyCountryName = "Canada", OlyGameID = "W", OlySportID = "C" },
                        new { OlyCountryID = 4, OlyCatID = "I", OlyCountryFlag = "China.png", OlyCountryName = "China", OlyGameID = "S", OlySportID = "D" },
                        new { OlyCountryID = 5, OlyCatID = "I", OlyCountryFlag = "Cyprus.png", OlyCountryName = "Cyprus", OlyGameID = "Y", OlySportID = "BD" },
                        new { OlyCountryID = 6, OlyCatID = "O", OlyCountryFlag = "Finland.png", OlyCountryName = "Finland", OlyGameID = "Y", OlySportID = "S" },
                        new { OlyCountryID = 7, OlyCatID = "I", OlyCountryFlag = "France.png", OlyCountryName = "France", OlyGameID = "Y", OlySportID = "BD" },
                        new { OlyCountryID = 8, OlyCatID = "I", OlyCountryFlag = "Germany.png", OlyCountryName = "Germany", OlyGameID = "S", OlySportID = "D" },
                        new { OlyCountryID = 9, OlyCatID = "I", OlyCountryFlag = "Great Britain.png", OlyCountryName = "Great Britain", OlyGameID = "W", OlySportID = "C" },
                        new { OlyCountryID = 10, OlyCatID = "O", OlyCountryFlag = "Italy.png", OlyCountryName = "Italy", OlyGameID = "W", OlySportID = "B" },
                        new { OlyCountryID = 11, OlyCatID = "O", OlyCountryFlag = "Jamaica.png", OlyCountryName = "Jamaica", OlyGameID = "W", OlySportID = "B" },
                        new { OlyCountryID = 12, OlyCatID = "O", OlyCountryFlag = "Japan.png", OlyCountryName = "Japan", OlyGameID = "W", OlySportID = "B" },
                        new { OlyCountryID = 13, OlyCatID = "I", OlyCountryFlag = "Mexico.png", OlyCountryName = "Mexico", OlyGameID = "S", OlySportID = "D" },
                        new { OlyCountryID = 14, OlyCatID = "O", OlyCountryFlag = "Netherlands.png", OlyCountryName = "Netherlands", OlyGameID = "S", OlySportID = "RC" },
                        new { OlyCountryID = 15, OlyCatID = "O", OlyCountryFlag = "Pakistan.png", OlyCountryName = "Pakistan", OlyGameID = "P", OlySportID = "CS" },
                        new { OlyCountryID = 16, OlyCatID = "O", OlyCountryFlag = "Portugal.png", OlyCountryName = "Portugal", OlyGameID = "Y", OlySportID = "S" },
                        new { OlyCountryID = 17, OlyCatID = "I", OlyCountryFlag = "Russia.png", OlyCountryName = "Russia", OlyGameID = "Y", OlySportID = "BD" },
                        new { OlyCountryID = 18, OlyCatID = "O", OlyCountryFlag = "Slovakia.png", OlyCountryName = "Slovakia", OlyGameID = "Y", OlySportID = "S" },
                        new { OlyCountryID = 19, OlyCatID = "I", OlyCountryFlag = "Sweden.png", OlyCountryName = "Sweden", OlyGameID = "W", OlySportID = "C" },
                        new { OlyCountryID = 20, OlyCatID = "O", OlyCountryFlag = "Thailand.png", OlyCountryName = "Thailand", OlyGameID = "P", OlySportID = "A" },
                        new { OlyCountryID = 21, OlyCatID = "O", OlyCountryFlag = "Ukraine.png", OlyCountryName = "Ukraine", OlyGameID = "P", OlySportID = "A" },
                        new { OlyCountryID = 22, OlyCatID = "O", OlyCountryFlag = "Uruguay.png", OlyCountryName = "Uruguay", OlyGameID = "P", OlySportID = "A" },
                        new { OlyCountryID = 23, OlyCatID = "O", OlyCountryFlag = "USA.png", OlyCountryName = "USA", OlyGameID = "S", OlySportID = "RC" },
                        new { OlyCountryID = 24, OlyCatID = "O", OlyCountryFlag = "Zimbabwe.png", OlyCountryName = "Zimbabwe", OlyGameID = "P", OlySportID = "CS" }
                    );
                });

            modelBuilder.Entity("OlympicProgram.Models.OlyGame", b =>
                {
                    b.Property<string>("OlyGameID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("OlyGameName");

                    b.HasKey("OlyGameID");

                    b.ToTable("OlyGames");

                    b.HasData(
                        new { OlyGameID = "P", OlyGameName = "Paralympics" },
                        new { OlyGameID = "S", OlyGameName = "Summer Olympics" },
                        new { OlyGameID = "W", OlyGameName = "Winter Olympics" },
                        new { OlyGameID = "Y", OlyGameName = "Youth Olympic Games" }
                    );
                });

            modelBuilder.Entity("OlympicProgram.Models.OlySport", b =>
                {
                    b.Property<string>("OlySportID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("OlySportName");

                    b.HasKey("OlySportID");

                    b.ToTable("OlySports");

                    b.HasData(
                        new { OlySportID = "A", OlySportName = "Archery" },
                        new { OlySportID = "B", OlySportName = "Bobsleigh" },
                        new { OlySportID = "BD", OlySportName = "Breakdancing" },
                        new { OlySportID = "CS", OlySportName = "Canoe Sprint" },
                        new { OlySportID = "C", OlySportName = "Curling" },
                        new { OlySportID = "D", OlySportName = "Diving" },
                        new { OlySportID = "RC", OlySportName = "Road Cycling" },
                        new { OlySportID = "S", OlySportName = "Skateboarding" }
                    );
                });

            modelBuilder.Entity("OlympicProgram.Models.OlyCountry", b =>
                {
                    b.HasOne("OlympicProgram.Models.OlyCat", "OlyCat")
                        .WithMany()
                        .HasForeignKey("OlyCatID");

                    b.HasOne("OlympicProgram.Models.OlyGame", "OlyGame")
                        .WithMany()
                        .HasForeignKey("OlyGameID");

                    b.HasOne("OlympicProgram.Models.OlySport", "OlySport")
                        .WithMany()
                        .HasForeignKey("OlySportID");
                });
#pragma warning restore 612, 618
        }
    }
}
