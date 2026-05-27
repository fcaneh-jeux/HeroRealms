using System;
using System.Collections.Generic;
using System.Text;
using HeroRealms.Core.Entities.Cards;

namespace HeroRealms.Core.Entities
{
    public class Board 
    { 
        public List<Card> PersistentCards { get; set; } = new(); 
        public List<ChampionCard> Champions { get; set; } = new(); 
    }
}
