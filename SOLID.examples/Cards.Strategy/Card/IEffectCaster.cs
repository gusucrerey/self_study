using Cards.Strategy.Effects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Strategy.Card
{
    public interface IEffectCaster
    {
        void ApplyEffectToOpponent(CardBase card);
    }
}
