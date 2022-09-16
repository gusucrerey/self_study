using Cards.Strategy.Effects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Strategy.Card
{
    public class Pawn : CardBase, IHealth, IWarrior
    {
        public int HealthScore { get; private set; }
        public int DamageAmount { get; private set; }


        public Pawn(string name, string description, int health, int damageAmount)
            : base(name, description)
        {
            HealthScore = health;
            DamageAmount = damageAmount;
            //CurrentEffects = new List<IEffect>();
        }

        public (string Name, int Health) Deconstruct()
        {
            return (Name, HealthScore);
        }

        public void Die()
        {
            CurrentEffects?.Clear();
            HealthScore = 0;
            DamageAmount = 0;
            ///TODO report and remove or wait till end of round to clear board?
            Console.WriteLine($"{Name} has died");
        }

        public void InflictDamage(IWarrior opponent)
        {
            Func<IEffect, bool> isPrevented = e => e.EffectNature is EffectNature.PreventAttack;
            if (CurrentEffects.Any(isPrevented))
            {
                IEffectStrategy strategy = CurrentEffects.First(isPrevented).Strategy;
                strategy.SufferEffect(this);
            }
            else
                opponent.AcceptDamage(DamageAmount);
        }

        public void AcceptDamage(int amount)
        {
            HealthScore -= amount;
            if (HealthScore <= 0)
                Die();
        }

    }
}
