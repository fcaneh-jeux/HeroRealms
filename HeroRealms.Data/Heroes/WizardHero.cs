using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using HeroRealms.Core.Definitions;
using HeroRealms.Core.Entities;
using HeroRealms.Core.Entities.Cards;
using HeroRealms.Core.Enums;

namespace HeroRealms.Data.Heroes
{
    public class WizardHero : HeroDefinition
    {
        public WizardHero()
        {
            Name = "Wizard";
            BaseHealth = 50;

            StartingHeroDeck = new List<Card>();

            for (int i = 0; i < 5; i++)
            {
                StartingHeroDeck.Add(new ArtifactCard
                {
                    Name = "Or",
                    Faction = FactionType.Hero,
                    Tags = new List<CardTag> { CardTag.Object, CardTag.Currency, CardTag.Coin },
                    BaseEffects = new List<Effect>
                    {
                        new Effect
                        {
                            EffectType = EffectType.Gold,
                            Value = 1
                        }
                    }
                });
            }

            StartingHeroDeck.Add(new ArtifactCard
            {
                Name = "Composant de Sort",
                Faction = FactionType.Hero,
                Tags = new List<CardTag> { CardTag.Ingredient, CardTag.Object},
                BaseEffects = new List<Effect>
                {
                    new Effect
                    {
                        EffectType = EffectType.Gold,
                        Value = 1
                    },

                    new Effect
                    {
                        EffectType = EffectType.ActionCostReduction,
                        Value = -1
                    } 
                }
            });

            StartingHeroDeck.Add(new ChampionCard
            {
                Name = "Familier Chat",
                Faction = FactionType.Hero,
                Tags = new List<CardTag> { CardTag.Champion, CardTag.Feline },
                BaseEffects = new List<Effect>
                {
                    new EffectChoice
                    {
                        AvailableEffects = new List<Effect>
                        {
                            new Effect
                            {
                                EffectType = EffectType.Damage,
                                Value = 1
                            },
                            new Effect
                            {
                                EffectType = EffectType.Gold,
                                Value = 1
                            },
                            new Effect{
                                EffectType = EffectType.Heal,
                                Value = 1
                            }
                        }
                    }
                },
                Shield = 2,
            });

            StartingHeroDeck.Add(new ArtifactCard
            {
                Name = "Bâton de Feu",
                Faction = FactionType.Hero,
                Tags = new List<CardTag> { CardTag.Staff, CardTag.MagicWeapon, CardTag.Object },
                BaseEffects = new List<Effect>
                {
                    new Effect
                    {
                        EffectType = EffectType.Damage,
                        Value = 1
                    }
                },
                SynergyEffects = new List<ConditionalEffect>
                {
                    new ConditionalEffect {
                        Condition = ConditionEffectType.AtLeastXCardsOfTypeInPlay,
                        EffectType = EffectType.Draw,
                        Value = 1,
                        CardTypeToCount = CardType.Action,
                        MinimumCardCount = 2
                    }
                }
            });

            for (int i = 0; i < 2; i++)
            {
                StartingHeroDeck.Add(new ActionCard
                {
                    Name = "Embraser",
                    Faction = FactionType.Hero,
                    Tags = new List<CardTag> { CardTag.Action, CardTag.Spell },
                    BaseEffects = new List<Effect>
                    {
                        new Effect
                        {
                            EffectType = EffectType.Damage,
                            Value = 2
                        }
                    }
                });
            }

            Powers = new List<Power>
            {
                new Power
                {
                    Name = "Transfert",
                    UsageType = PowerUsageType.OncePerTurn,
                    IsCastable = true,
                    Cost = 2,
                    Effects = new List<Effect>
                    {
                        new Effect
                        {
                            EffectType = EffectType.SelfDamage,
                            Value = 1
                        },
                        new Effect
                        {
                            EffectType = EffectType.Draw,
                            Value = 1
                        }
                    }

                },
                new Power
                {
                    Name = "Boule de Feu",
                    UsageType = PowerUsageType.OncePerGame,
                    IsCastable = true,
                    Effects = new List<Effect>
                    {
                        new Effect
                        {
                            EffectType = EffectType.Damage,
                            Value = 4
                        }
                    }
                }
            };
        }
    }
}

