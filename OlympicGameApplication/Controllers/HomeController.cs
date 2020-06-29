using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OlympicGameApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace OlympicGameApplication.Controllers
{
    public class HomeController : Controller
    {
        private OlympicGamesContext Context;
        public HomeController(OlympicGamesContext context)
        {
            Context = context;
        }

        public IActionResult Index(string indoorOutdoorType = "All", string gameType = "All")
        {
            List<GameType> GameTypes = Context.GameTypes.ToList();
            GameTypes.Insert(0, new GameType { GameTypeName = "All" });
            ViewBag.GameTypes = GameTypes;
            ViewBag.ActiveGameType = gameType;

            List<Indoor_Outdoor> IndoorOutdoorTypes = Context.IndoorOutdoorTypes.ToList();
            IndoorOutdoorTypes.Insert(0, new Indoor_Outdoor { Indoor_OutdoorType = "All" });
            ViewBag.IndoorOutdoorTypes = IndoorOutdoorTypes;
            ViewBag.IndoorOutdoorTypes = IndoorOutdoorTypes;

            List<Country> countries;
            if (indoorOutdoorType.ToLower() != "all")
            {
                if (gameType.ToLower() != "all")
                {
                    countries = Context.Countries.Include(c => c.GameType)
                        .Include(c => c.Sport).Include(c => c.Sport.Indoor_Outdoor).OrderBy(c => c.CountryName)
                        .Where(c => c.GameType.GameTypeName.ToLower() == gameType.ToLower())
                        .Where(c => c.Sport.Indoor_Outdoor.Indoor_OutdoorType.ToLower() == indoorOutdoorType.ToLower()).ToList();
                }
                else
                {
                    countries = Context.Countries.Include(c => c.GameType)
                        .Include(c => c.Sport).Include(c => c.Sport.Indoor_Outdoor).OrderBy(c => c.CountryName)
                        .Where(c => c.Sport.Indoor_Outdoor.Indoor_OutdoorType.ToLower() == indoorOutdoorType.ToLower()).ToList();
                }
            }
            else if (gameType.ToLower() != "all")
            {
                countries = Context.Countries.Include(c => c.GameType)
                    .Include(c => c.Sport).Include(c => c.Sport.Indoor_Outdoor).OrderBy(c => c.CountryName)
                    .Where(c => c.GameType.GameTypeName.ToLower() == gameType.ToLower()).ToList();
            }
            else
            {
                countries = Context.Countries.Include(c => c.GameType)
                    .Include(c => c.Sport).Include(c => c.Sport.Indoor_Outdoor).OrderBy(c => c.CountryName).ToList();
            }
            return View(countries);
        }
    }
}