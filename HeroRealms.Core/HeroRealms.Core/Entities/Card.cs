using System;
using System.Collections.Generic;
using System.Text;

namespace HeroRealms.Core.Entities
{
    public class Card 
    { 
        public string Name { get; set; } = string.Empty; 
        public int Cost { get; set; } 
        public string Faction { get; set; } = string.Empty; 
        public List<Effect> BaseEffects { get; set; } = new();
        public List<Effect> SynergyEffects { get; set; } = new();
    }
}
