using Cards.Strategy.Card;
using Cards.Strategy.Strategies.Affect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Strategy.Effects
{
    public class SleepEffect : PreventActionStrategy, IEffect
    {
        public EffectNature EffectNature { get; private set; }
        public IEffectStrategy Strategy { get; private set; }

        public SleepEffect(string name, string description, int roundsAffected)
        {
            Name = name;
            Description = description;
            RoundsRemaining = roundsAffected;
            EffectNature = EffectNature.PreventAttack;
            Strategy = new PreventActionStrategy();
        }

        public int CurrentEffectStack { get; set; }

        public int RoundsRemaining { get; private set; }

        public string Name { get; private set; }

        public string Description { get; private set; }


        public void ApplyEffect(CardBase card, IEffect effect)
        {
            //if the affect can apply, add it to the list
            card.ApplyEffect(effect);
        }

        public void SufferEffect(CardBase card)
        {
            if(card is IWarrior)
            {
                Console.WriteLine($"Warrior {card.Name} can't do anything, sleeping");
            }
        }
    }
}
