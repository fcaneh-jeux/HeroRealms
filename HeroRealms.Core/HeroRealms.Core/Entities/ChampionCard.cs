using System;
using System.Collections.Generic;
using System.Text;

namespace HeroRealms.Core.Entities
{
    public class ChampionCard : Card
    {
        public int Health { get; set; }
        public bool IsGuard { get; set; }
        public bool IsExhausted { get; set; }
    }
}
