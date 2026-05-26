using System;
using System.Collections.Generic;
using System.Text;

namespace HeroRealms.Core.Entities
{
    public class Hero 
    { 
        public string Name { get; set; } = string.Empty; 
        public int Health { get; set; } 
        public List<Power> Powers { get; set; } = new();
        public List<Card> PersonalCards { get; } = new();
    }
}
