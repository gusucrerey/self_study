using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.examples.SingleResponsibility
{
    public abstract class CultMember : ICharacter, ICultist
    {
        public abstract string FirstName { get; set; }
        public abstract string LastName { get; set; }
        public abstract string CultName { get; set; }

        public abstract void DoCultStuff();
        public abstract void ProtectCultLeader();
    }
}
