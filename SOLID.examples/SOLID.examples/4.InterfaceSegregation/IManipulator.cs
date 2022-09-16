using SOLID.examples.SingleResponsibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.examples.InterfaceSegregation
{
    public interface IManipulator
    {
        int AssessPotentialToManipulate();
        void ApplyFear(CultMember cultist);
        void ApplyHope(CultMember cultist);
        void DemandPurity(CultMember cultist);
        void IsolateFromFriendsAndFamily(CultMember cultist);
    }
}
