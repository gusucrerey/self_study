using Cards.Strategy.Effects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Strategy.Card
{
    public abstract class Bishop : CardBase, IHealth, IEffectCaster
    {
        private SleepEffect _sleepEffect;
        public int HealthScore { get; private set; }
        public Bishop(string name, string description, int health)
            : base(name, description)
        {
            HealthScore = health;
            _sleepEffect = new SleepEffect("Peaceful Dreaming", "Puts the opponent into a peaceful slumber", 3);
        }

        public (string Name, int Health) Deconstruct()
        {
            return (Name, HealthScore);
        }



        public void AcceptDamage(int amount)
        {
            HealthScore -= amount;
            if (HealthScore <= 0)
                Die();
        }

       public void Die()
        {
            CurrentEffects?.Clear();
            HealthScore = 0;
            ///TODO report and remove or wait till end of round to clear board?
            Console.WriteLine($"{Name} has died");
        }

        //public void InflictDamage(IWarrior opponent)
        //{
        //    throw new NotImplementedException();
        //}

        public void ApplyEffectToOpponent(CardBase card)
        {
            
        }
    }
}
