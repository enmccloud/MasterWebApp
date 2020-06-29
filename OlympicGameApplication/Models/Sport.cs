using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympicGameApplication.Models
{
    public class Sport
    {
        public int SportID { get; set; }
        public string SportName { get; set; }
        public int Indoor_OutdoorType { get; set; }
        public Indoor_Outdoor Indoor_Outdoor { get; set; }
    }
}
