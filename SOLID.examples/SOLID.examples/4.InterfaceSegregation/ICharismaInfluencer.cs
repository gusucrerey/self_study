using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.examples.InterfaceSegregation
{
    public interface ICharismaInfluencer
    {
        bool Bluff();
        bool Charm();
        bool Intimidate();
        bool UseDiplomacy();
    }
}
