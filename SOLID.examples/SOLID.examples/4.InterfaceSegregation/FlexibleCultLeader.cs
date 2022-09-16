using SOLID.examples.SingleResponsibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.examples.InterfaceSegregation
{
    public class FlexibleCultLeader : ICharismaInfluencer, IManipulator, INarcissist
    {
        public void ApplyFear(CultMember cultist)
        {
            throw new NotImplementedException();
        }

        public void ApplyHope(CultMember cultist)
        {
            throw new NotImplementedException();
        }

        public int AssessPotentialToManipulate()
        {
            throw new NotImplementedException();
        }

        public bool Bluff()
        {
            Console.WriteLine("Maybe you misheard me,.. I never said that.");
            return true;
        }

        public bool Charm()
        {
            Console.WriteLine("You look so beautiful!");
            return true;
        }

        public void DemandPurity(CultMember cultist)
        {
            throw new NotImplementedException();
        }

        public bool Intimidate()
        {
            Console.WriteLine("JUST DO IT!");
            return true;
        }

        public void IsolateFromFriendsAndFamily(CultMember cultist)
        {
            throw new NotImplementedException();
        }

        public bool IsThisGoodForMe()
        {
            throw new NotImplementedException();
        }

        public bool UseDiplomacy()
        {
            Console.WriteLine("My plan makes more sense");
            return true;
        }
    }
}
