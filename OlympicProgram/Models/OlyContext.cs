using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OlympicProgram.Models
{
    // Setting up database structure
    public class OlyContext : DbContext
    {
        public OlyContext(DbContextOptions options)
            : base(options) { }

        public DbSet<OlyCountry> OlyCountries { get; set; }

        public DbSet<OlyCat> OlyCats { get; set; }

        public DbSet<OlyGame> OlyGames { get; set; }

        public DbSet<OlySport> OlySports { get; set; }

        // Referencing my SQL Server
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Server=tcp:cis174enmccloud.database.windows.net,1433;Initial Catalog=CIS174enmccloud;Persist Security Info=False;User ID=enmccloud;Password=Skittles5309;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");


        //Building the DB Model
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<OlyCat>().HasData(

                new OlyCat
                {
                    OlyCatName = "Indoor",
                    OlyCatID = "I"
                },

                new OlyCat
                {
                    OlyCatName = "OutDoor",
                    OlyCatID = "O"
                });

            modelBuilder.Entity<OlyGame>().HasData(

                new OlyGame
                {
                    OlyGameName = "Paralympics",
                    OlyGameID = "P"
                },

                new OlyGame
                {
                    OlyGameName = "Summer Olympics",
                    OlyGameID = "S"
                },

                new OlyGame
                {
                    OlyGameName = "Winter Olympics",
                    OlyGameID = "W"
                },

                new OlyGame
                {
                    OlyGameName = "Youth Olympic Games",
                    OlyGameID = "Y"
                });

            modelBuilder.Entity<OlySport>().HasData(

                new OlySport
                {
                    OlySportName = "Archery",
                    OlySportID = "A"
                },

                new OlySport
                {
                    OlySportName = "Bobsleigh",
                    OlySportID = "B"
                },

                new OlySport
                {
                    OlySportName = "Breakdancing",
                    OlySportID = "BD"
                },

                new OlySport
                {
                    OlySportName = "Canoe Sprint",
                    OlySportID = "CS"
                },

                new OlySport
                {
                    OlySportName = "Curling",
                    OlySportID = "C"
                },

                new OlySport
                {
                    OlySportName = "Diving",
                    OlySportID = "D"
                },

                new OlySport
                {
                    OlySportName = "Road Cycling",
                    OlySportID = "RC"
                },

                new OlySport
                {
                    OlySportName = "Skateboarding",
                    OlySportID = "S"
                });

            modelBuilder.Entity<OlyCountry>().HasData(

                new OlyCountry
                {
                    OlyCountryName = "Austria",
                    OlyCountryID = 1,
                    OlyCountryFlag = "Austria.png",
                    OlyGameID = "P",
                    OlySportID = "CS",
                    OlyCatID = "O"
                },

                new OlyCountry
                {
                    OlyCountryName = "Brazil",
                    OlyCountryID = 2,
                    OlyCountryFlag = "Brazil.png",
                    OlyGameID = "S",
                    OlySportID = "RC",
                    OlyCatID = "O"
                },

                new OlyCountry
                {
                    OlyCountryName = "Canada",
                    OlyCountryID = 3,
                    OlyCountryFlag = "Canada.png",
                    OlyGameID = "W",
                    OlySportID = "C",
                    OlyCatID = "I"
                },

                new OlyCountry
                {
                    OlyCountryName = "China",
                    OlyCountryID = 4,
                    OlyCountryFlag = "China.png",
                    OlyGameID = "S",
                    OlySportID = "D",
                    OlyCatID = "I"
                },

                new OlyCountry
                {
                    OlyCountryName = "Cyprus",
                    OlyCountryID = 5,
                    OlyCountryFlag = "Cyprus.png",
                    OlyGameID = "Y",
                    OlySportID = "BD",
                    OlyCatID = "I"
                },

                new OlyCountry
                {
                    OlyCountryName = "Finland",
                    OlyCountryID = 6,
                    OlyCountryFlag = "Finland.png",
                    OlyGameID = "Y",
                    OlySportID = "S",
                    OlyCatID = "O"
                },

                new OlyCountry
                {
                    OlyCountryName = "France",
                    OlyCountryID = 7,
                    OlyCountryFlag = "France.png",
                    OlyGameID = "Y",
                    OlySportID = "BD",
                    OlyCatID = "I"
                },

                new OlyCountry
                {
                    OlyCountryName = "Germany",
                    OlyCountryID = 8,
                    OlyCountryFlag = "Germany.png",
                    OlyGameID = "S",
                    OlySportID = "D",
                    OlyCatID = "I"
                },

                new OlyCountry
                {
                    OlyCountryName = "Great Britain",
                    OlyCountryID = 9,
                    OlyCountryFlag = "Great Britain.png",
                    OlyGameID = "W",
                    OlySportID = "C",
                    OlyCatID = "I"
                },

                new OlyCountry
                {
                    OlyCountryName = "Italy",
                    OlyCountryID = 10,
                    OlyCountryFlag = "Italy.png",
                    OlyGameID = "W",
                    OlySportID = "B",
                    OlyCatID = "O"
                },

                new OlyCountry
                {
                    OlyCountryName = "Jamaica",
                    OlyCountryID = 11,
                    OlyCountryFlag = "Jamaica.png",
                    OlyGameID = "W",
                    OlySportID = "B",
                    OlyCatID = "O"
                },

                new OlyCountry
                {
                    OlyCountryName = "Japan",
                    OlyCountryID = 12,
                    OlyCountryFlag = "Japan.png",
                    OlyGameID = "W",
                    OlySportID = "B",
                    OlyCatID = "O"
                },

                new OlyCountry
                {
                    OlyCountryName = "Mexico",
                    OlyCountryID = 13,
                    OlyCountryFlag = "Mexico.png",
                    OlyGameID = "S",
                    OlySportID = "D",
                    OlyCatID = "I"
                },

                new OlyCountry
                {
                    OlyCountryName = "Netherlands",
                    OlyCountryID = 14,
                    OlyCountryFlag = "Netherlands.png",
                    OlyGameID = "S",
                    OlySportID = "RC",
                    OlyCatID = "O"
                },

                new OlyCountry
                {
                    OlyCountryName = "Pakistan",
                    OlyCountryID = 15,
                    OlyCountryFlag = "Pakistan.png",
                    OlyGameID = "P",
                    OlySportID = "CS",
                    OlyCatID = "O"
                },

                new OlyCountry
                {
                    OlyCountryName = "Portugal",
                    OlyCountryID = 16,
                    OlyCountryFlag = "Portugal.png",
                    OlyGameID = "Y",
                    OlySportID = "S",
                    OlyCatID = "O"
                },

                new OlyCountry
                {
                    OlyCountryName = "Russia",
                    OlyCountryID = 17,
                    OlyCountryFlag = "Russia.png",
                    OlyGameID = "Y",
                    OlySportID = "BD",
                    OlyCatID = "I"
                },

                new OlyCountry
                {
                    OlyCountryName = "Slovakia",
                    OlyCountryID = 18,
                    OlyCountryFlag = "Slovakia.png",
                    OlyGameID = "Y",
                    OlySportID = "S",
                    OlyCatID = "O"
                },

                new OlyCountry
                {
                    OlyCountryName = "Sweden",
                    OlyCountryID = 19,
                    OlyCountryFlag = "Sweden.png",
                    OlyGameID = "W",
                    OlySportID = "C",
                    OlyCatID = "I"
                },

                new OlyCountry
                {
                    OlyCountryName = "Thailand",
                    OlyCountryID = 20,
                    OlyCountryFlag = "Thailand.png",
                    OlyGameID = "P",
                    OlySportID = "A",
                    OlyCatID = "O"
                },

                new OlyCountry
                {
                    OlyCountryName = "Ukraine",
                    OlyCountryID = 21,
                    OlyCountryFlag = "Ukraine.png",
                    OlyGameID = "P",
                    OlySportID = "A",
                    OlyCatID = "O"
                },

                new OlyCountry
                {
                    OlyCountryName = "Uruguay",
                    OlyCountryID = 22,
                    OlyCountryFlag = "Uruguay.png",
                    OlyGameID = "P",
                    OlySportID = "A",
                    OlyCatID = "O"
                },

                new OlyCountry
                {
                    OlyCountryName = "USA",
                    OlyCountryID = 23,
                    OlyCountryFlag = "USA.png",
                    OlyGameID = "S",
                    OlySportID = "RC",
                    OlyCatID = "O"
                },

                new OlyCountry
                {
                    OlyCountryName = "Zimbabwe",
                    OlyCountryID = 24,
                    OlyCountryFlag = "Zimbabwe.png",
                    OlyGameID = "P",
                    OlySportID = "CS",
                    OlyCatID = "O"
                }
                );
        }
    }
}
