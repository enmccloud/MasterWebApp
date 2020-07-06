using OlympicProgram.Models;
using System.Collections.Generic;

namespace OlympicProgram1.Models
{
    public class Detail
    {
        public bool Favorite { get; set; }
        public OlyCountry OlyCountry { get; set; }
        public List<OlyCountry> FavoriteList { get; set; }
    }
}
