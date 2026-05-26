using System;
using System.Collections.Generic;
using System.Text;

namespace HeroRealms.Core.Entities
{
    public class Board 
    { 
        public List<Card> PersistentCards { get; set; } = new(); 
        public List<Champion> Champions { get; set; } = new(); 
    }
}
