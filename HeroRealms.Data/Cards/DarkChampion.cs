using System;
using System.Collections.Generic;
using System.Text;
using HeroRealms.Core.Entities.Cards;

namespace HeroRealms.Data.Cards
{
    public static class DarkChampion
    {
        public static ChampionCard Create() { 
            return new ChampionCard()
            {
                Name = "Dark Champion",
                Cost = 5,

            };
        }
    }
}
