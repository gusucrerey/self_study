using Cards.Strategy.Card;
using Cards.Strategy.Strategies.Affect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Strategy.Effects
{
    public class PreventActionStrategy : IEffectStrategy
    {
        public void ApplyEffect(CardBase card, IEffect effect)
        {
            card.ApplyEffect(effect);
        }

        public void SufferEffect(CardBase card)
        {
            Console.WriteLine($"{card.Name} is prevented from action");
        }
    }
}
