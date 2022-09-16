using Cards.Strategy.Card;
using Cards.Strategy.Effects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Strategy.Strategies.Affect
{
    public static class AffectAppliers
    {
        public static void ApplyEffect(this CardBase card, IEffect effect)
        {
            Func<IEffect, bool> matchOnName = e => e.Name == effect.Name;
            ///TODO: deal with rounds later
            if (card.CurrentEffects.Any(matchOnName))                
            {
                IEffect existingEffect = card.CurrentEffects.First(matchOnName);
                if (effect is IStackableEffect)
                {

                    existingEffect.CurrentEffectStack += 1;
                }
                else
                {
                    existingEffect.CurrentEffectStack = 1;
                }
            }
            else
            {
                card.CurrentEffects.Add(effect);
            }
        }
    }
}
