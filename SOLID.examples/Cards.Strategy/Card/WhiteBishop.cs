using Cards.Strategy.Effects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Strategy.Card
{
    public class WhiteBishop : Bishop
    {
        public WhiteBishop(string name, string description, int health) 
            : base(name, description, health)
        {
        }
    }
}
