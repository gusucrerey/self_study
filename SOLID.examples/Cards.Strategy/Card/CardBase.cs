using Cards.Strategy.Effects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Strategy.Card
{
    public abstract class CardBase
    {
        public CardBase(string name, string description)
        {
            Name = name;
            Description = description;
            CurrentEffects = new List<IEffect>();
        }
        public IList<IEffect> CurrentEffects { get; }
        public int WillPower { get; }
        public string Name { get; }
        public string Description { get; }

    }
}
