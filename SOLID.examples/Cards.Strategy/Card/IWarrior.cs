using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Strategy.Card
{
    public interface IWarrior
    {
        int DamageAmount { get; }
        void InflictDamage(IWarrior opponent);
        void AcceptDamage(int amount);
        void Die();
    }
}
