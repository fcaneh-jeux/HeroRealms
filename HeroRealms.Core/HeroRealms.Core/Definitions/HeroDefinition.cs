using System;
using System.Collections.Generic;
using System.Text;
using HeroRealms.Core.Entities;
using HeroRealms.Core.Entities.Cards;

namespace HeroRealms.Core.Definitions
{
    public class HeroDefinition
    {
        public string Name { get; set; } = string.Empty; 
        public int BaseHealth { get; set; }
        public List<Card> StartingHeroDeck { get; set; } = new(); 
        public List<Power> Powers { get; set; } = new();
    }
}
