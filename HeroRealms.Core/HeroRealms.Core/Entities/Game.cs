using System;
using System.Collections.Generic;
using System.Text;
using HeroRealms.Core.Entities.Cards;

namespace HeroRealms.Core.Entities
{
    public class Game 
    { 
        public List<Player> Players { get; set; } = new(); 
        public List<Card> River { get; set; } = new(); 
        public int CurrentPlayerIndex { get; set; } 
    }
}
