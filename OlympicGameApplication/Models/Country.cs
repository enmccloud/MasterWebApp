using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OlympicGameApplication.Models
{
    public class Country
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        public string CountryFlag { get { return "~/Views/CountryFlags/" + CountryName + ".png"; } }

        public int GameTypeID { get; set; }
        public GameType GameType { get; set; }
        public int SportID { get; set; }
        public Sport Sport { get; set; }
        public int Indoor_OutdoorID { get;set;} 
        public Indoor_Outdoor Indoor_Outdoor { get; set; }
    }
}
