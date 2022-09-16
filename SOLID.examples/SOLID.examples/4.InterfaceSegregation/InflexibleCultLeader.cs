using SOLID.examples.SingleResponsibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.examples.InterfaceSegregation
{
    public class InflexibleCultLeader : IGeneralInfluencer
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
            Console.WriteLine("Just the tip");
            return true;
        }

        public bool Charm()
        {
            Console.WriteLine("Arent you wonderful!");
            return true;
        }

        public void DemandPurity(CultMember cultist)
        {
            throw new NotImplementedException("Not really an Influencer thing");
        }

        public bool Intimidate()
        {
            Console.WriteLine("Do it or you cant get into Heaven");
            return true;
        }

        public void IsolateFromFriendsAndFamily(CultMember cultist)
        {
            throw new NotImplementedException("Not really an Influencer thing");
        }

        public bool IsThisGoodForMe()
        {
            throw new NotImplementedException();
        }

        public bool UseDiplomacy()
        {
            Console.WriteLine("Doesnt my plan make the most sense?");
            return true;
        }
    }
}
