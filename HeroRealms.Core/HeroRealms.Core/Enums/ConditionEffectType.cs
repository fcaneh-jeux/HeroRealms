using System;
using System.Collections.Generic;
using System.Text;

namespace HeroRealms.Core.Enums
{
    public enum ConditionEffectType
    {
        SameFactionPlayed,
        SameCardTypePlayed,
        ChampionControlled,
        LowHealth,
        EnemyChampionPresent,
        ChampionAlreadyExhausted,
        AtLeastXCardsOfTypeInPlay
    }
}
