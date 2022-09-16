using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Strategy.Effects
{
    public interface IStackableEffect: IEffect
    {
        int MaxEffectStack { get; }
    }
}
