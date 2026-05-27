using System;
using System.Collections.Generic;
using System.Text;
using HeroRealms.Core.Enums;

namespace HeroRealms.Core.Entities.Cards
{
    public abstract class Card 
    { 
        public string Name { get; set; } = string.Empty; 
        public int Cost { get; set; } 
        public FactionType Faction { get; set; }
        public List<Effect> BaseEffects { get; set; } = new();
        public List<ConditionalEffect> SynergyEffects { get; set; } = new();
        public abstract CardType CardType { get; }
    }
}
