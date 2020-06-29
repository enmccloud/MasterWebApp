using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace OlympicGameApplication.Models
{
    public class OlympicGamesContext : DbContext
    {

        public OlympicGamesContext(DbContextOptions<OlympicGamesContext> Options)
            : base(Options)
        {
        }

        public DbSet<Country> Countries { get; set; }

        public DbSet<GameType> GameTypes { get; set; }

        public DbSet<Indoor_Outdoor> IndoorOutdoorTypes { get; set; }

        public DbSet<Sport> Sports { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Server=tcp:cis174enmccloud.database.windows.net,1433;Initial Catalog=CIS174enmccloud;Persist Security Info=False;User ID=enmccloud;Password=Skittles5309;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Indoor_Outdoor>().HasData
                (
                    new Indoor_Outdoor
                    {
                        Indoor_OutdoorType = "Indoor",
                        Indoor_OutdoorID = 1
                    },

                    new Indoor_Outdoor
                    {
                        Indoor_OutdoorType = "OutDoor",
                        Indoor_OutdoorID = 2
                    }
                );

            builder.Entity<GameType>().HasData
                (
                new GameType
                {
                    GameTypeName = "Paralympics",
                    GameTypeID = 1
                },

                new GameType
                {
                    GameTypeName = "Summer Olympics",
                    GameTypeID = 2
                },

                new GameType
                { GameTypeName = "Winter Olympics",
                    GameTypeID = 3
                },

                new GameType
                {
                    GameTypeName = "Youth Olympic Games",
                    GameTypeID = 4
                }
                );

            builder.Entity<Sport>().HasData
                (
                new Sport
                {
                    SportName = "Archery",
                    SportID = 1
                },

                new Sport
                {
                    SportName = "Bobsleigh",
                    SportID = 2
                },

                new Sport
                {
                    SportName = "Break Dancing",
                    SportID = 3
                },

                new Sport
                {
                    SportName = "Canoe Sprint",
                    SportID = 4
                },

                new Sport
                {
                    SportName = "Curling",
                    SportID = 5
                },

                new Sport
                {
                    SportName = "Diving",
                    SportID = 6
                },

                new Sport
                {
                    SportName = "Road Cycling",
                    SportID = 7
                },

                new Sport
                {
                    SportName = "Skateboarding",
                    SportID = 8
                }
                );

            builder.Entity<Country>().HasData
                (
                new Country
                {
                    CountryName = "Austria",
                    CountryID = 1,
                    GameTypeID = 1,
                    SportID = 4,
                    Indoor_OutdoorID = 2

                },

                new Country
                {
                    CountryName = "Brazil",
                    CountryID = 2,
                    GameTypeID = 2,
                    SportID = 7,
                    Indoor_OutdoorID = 2
                },

                new Country
                {
                    CountryName = "Canada",
                    CountryID = 3,
                    GameTypeID = 3,
                    SportID = 5,
                    Indoor_OutdoorID = 1
                },

                new Country
                {
                    CountryName = "China",
                    CountryID = 4,
                    GameTypeID = 2,
                    SportID = 6,
                    Indoor_OutdoorID = 1
                },

                new Country
                {
                    CountryName = "Cyprus",
                    CountryID = 5,
                    GameTypeID = 4,
                    SportID = 3,
                    Indoor_OutdoorID = 1
                },

                new Country
                {
                    CountryName = "Finland",
                    CountryID = 6,
                    GameTypeID = 4,
                    SportID = 8,
                    Indoor_OutdoorID = 2
                },

                new Country
                {
                    CountryName = "France",
                    CountryID = 7,
                    GameTypeID = 4,
                    SportID = 3,
                    Indoor_OutdoorID = 1
                },

                new Country
                {
                    CountryName = "Germany",
                    CountryID = 8,
                    GameTypeID = 2,
                    SportID = 6,
                    Indoor_OutdoorID = 1
                },

                new Country
                {
                    CountryName = "Great Britain",
                    CountryID = 9,
                    GameTypeID = 3,
                    SportID = 5,
                    Indoor_OutdoorID = 1
                },

                new Country
                {
                    CountryName = "Italy",
                    CountryID = 10,
                    GameTypeID = 3,
                    SportID = 2,
                    Indoor_OutdoorID = 2
                },

                new Country
                {
                    CountryName = "Jamaica",
                    CountryID = 11,
                    GameTypeID = 3,
                    SportID = 2,
                    Indoor_OutdoorID = 2
                },

                new Country
                {
                    CountryName = "Japan",
                    CountryID = 12,
                    GameTypeID = 3,
                    SportID = 2,
                    Indoor_OutdoorID = 2
                },

                new Country
                {
                    CountryName = "Mexico",
                    CountryID = 13,
                    GameTypeID = 2,
                    SportID = 6,
                    Indoor_OutdoorID = 1
                },

                new Country
                {
                    CountryName = "Netherlands",
                    CountryID = 14,
                    GameTypeID = 2,
                    SportID = 7,
                    Indoor_OutdoorID = 2
                },

                new Country
                {
                    CountryName = "Pakistan",
                    CountryID = 15,
                    GameTypeID = 1,
                    SportID = 4,
                    Indoor_OutdoorID = 2
                },

                new Country
                {
                    CountryName = "Portugal",
                    CountryID = 16,
                    GameTypeID = 4,
                    SportID = 8,
                    Indoor_OutdoorID = 2
                },

                new Country
                {
                    CountryName = "Russia",
                    CountryID = 17,
                    GameTypeID = 4,
                    SportID = 3,
                    Indoor_OutdoorID = 1
                },

                new Country
                {
                    CountryName = "Slovakia",
                    CountryID = 18,
                    GameTypeID = 4,
                    SportID = 8,
                    Indoor_OutdoorID = 2
                },

                new Country
                {
                    CountryName = "Sweden",
                    CountryID = 19,
                    GameTypeID = 3,
                    SportID = 5,
                    Indoor_OutdoorID = 1
                },

                new Country
                {
                    CountryName = "Thailand",
                    CountryID = 20,
                    GameTypeID = 1,
                    SportID = 1,
                    Indoor_OutdoorID = 2
                },

                new Country
                {
                    CountryName = "Ukraine",
                    CountryID = 21,
                    GameTypeID = 1,
                    SportID = 1,
                    Indoor_OutdoorID = 2 },

                new Country
                {
                    CountryName = "Uruguay",
                    CountryID = 22,
                    GameTypeID = 1,
                    SportID = 1,
                    Indoor_OutdoorID = 2
                },

                new Country
                {
                    CountryName = "USA",
                    CountryID = 23,
                    GameTypeID = 2,
                    SportID = 7,
                    Indoor_OutdoorID = 2
                },

                new Country
                {
                    CountryName = "Zimbabwe",
                    CountryID = 24,
                    GameTypeID = 1,
                    SportID = 4,
                    Indoor_OutdoorID = 2
                }
                );
        }
        }
    }





