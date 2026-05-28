using System;
using System.Collections.Generic;
using System.Text;
using HeroRealms.Core.Enums;

namespace HeroRealms.Core.Entities
{
    public class ConditionalEffect : Effect 
    { 
        public ConditionEffectType Condition { get; set; } 
        public CardType CardTypeToCount { get; set; }
        public int MinimumCardCount { get; set; }
    }
}
