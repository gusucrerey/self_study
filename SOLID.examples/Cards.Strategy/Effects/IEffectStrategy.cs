using Cards.Strategy.Card;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Strategy.Effects
{
    public interface IEffectStrategy
    {
        void ApplyEffect(CardBase card, IEffect effect);
        void SufferEffect(CardBase card);
    }
}
