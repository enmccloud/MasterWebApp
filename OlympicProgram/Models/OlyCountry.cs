using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympicProgram.Models
{
    // Properties for my Olympic Country including references to other classes.
    public class OlyCountry
    {
        public int OlyCountryID { get; set; }

        public string OlyCountryName { get; set; }

        public string OlyCountryFlag { get; set; }

        public OlyCat OlyCat { get; set; }

        public string OlyCatID { get; set; }

        public OlyGame OlyGame { get; set; }

        public string OlyGameID { get; set; }

        public OlySport OlySport { get; set; }

        public string OlySportID { get; set; }
    }
}
