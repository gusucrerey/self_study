using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Strategy.Effects
{
    public interface IEffect
    {
        EffectNature EffectNature { get; }
        int CurrentEffectStack { get; set; }
        int RoundsRemaining { get; }
        string Name { get; }
        string Description { get; }
        IEffectStrategy Strategy { get; }
    }
}
