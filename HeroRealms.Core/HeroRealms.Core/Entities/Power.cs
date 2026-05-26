using System;
using System.Collections.Generic;
using System.Text;
using HeroRealms.Core.Enums;

namespace HeroRealms.Core.Entities
{
    public class Power 
    { 
        public string Name { get; set; } = string.Empty; 
        public PowerUsageType UsageType { get; set; } 
        public bool IsCastable { get; set; } = true; 
    }
}
