using System;
using System.Collections.Generic;
using System.Text;

namespace HeroRealms.Core.Entities
{
    public class Player
    {
        public Hero Hero { get; set; } = null!;
        public List<Card> Deck { get; set; } = new();
        public List<Card> Hand { get; set; } = new();
        public List<Card> DiscardPile { get; set; } = new();
        public Board Board { get; set; } = new();

        public Player(Hero hero)
        {
            Hero = hero;
            Deck = hero.PersonalCards.ToList();
        }
    }
}
