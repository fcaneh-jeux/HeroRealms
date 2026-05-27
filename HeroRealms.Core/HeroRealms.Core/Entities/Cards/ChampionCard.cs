using System;
using System.Collections.Generic;
using System.Text;
using HeroRealms.Core.Enums;

namespace HeroRealms.Core.Entities.Cards
{
    public class ChampionCard : Card
    {
        public int Health { get; set; }
        public bool IsGuard { get; set; }
        public bool IsExhausted { get; set; }
        public override CardType CardType => CardType.Champion;
    }
}
