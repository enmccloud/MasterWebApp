using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using OlympicProgram.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OlympicProgram1.Models
{
    public class Favorite
    {
        private readonly ISession Session;

        public Favorite(ISession Session)
        {
            this.Session = Session;
        }

        public void SaveFavorite(List<OlyCountry> olyCountries)
        {
            Session.SetString("Favorite", JsonConvert.SerializeObject(olyCountries));
        }

        public List<OlyCountry> AddFavorite()
        {
            List<OlyCountry> Favorite;
            if (Session.Keys.Contains("Favorite"))
            {
                Favorite = JsonConvert.DeserializeObject<List<OlyCountry>>(Session.GetString("Favorite"));
            }
            else
            {
                Favorite = null;
            }
            return Favorite;
        }

        public bool FavoriteValid(OlyCountry olyCountry)
        {
            bool? favoriteState = AddFavorite()?.Find(t => t.OlyCountryName == olyCountry.OlyCountryName) == null ? false : true;
            return favoriteState != null ? favoriteState.Value : false;
        }
    }
}
