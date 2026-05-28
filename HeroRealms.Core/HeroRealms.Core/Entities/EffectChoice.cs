using System;
using System.Collections.Generic;
using System.Text;

namespace HeroRealms.Core.Entities
{
    public class EffectChoice : Effect
    {
        public List<Effect> AvailableEffects {  get; set; } = new ();
        public Effect SelectedEffect { get; private set; } = null!;

        public void SelectEffect(Effect effect)
        {
            if (!AvailableEffects.Contains(effect))
                throw new ArgumentException("Selected effect is not in the list of available effects.");
            SelectedEffect = effect;
        }
    }
}
