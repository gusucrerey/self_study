using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.examples.SingleResponsibility
{
    public class GoodCultMember : CultMember
    {
        public override string FirstName { get; set; }
        public override string LastName { get; set; }
        public override string CultName { get; set; }

        public GoodCultMember(string fname, string lname, string cultname)
        {
            FirstName = fname;
            LastName = lname;
            CultName = cultname;

            DoSomeKindOfNonCultStuff("Not yet isolating from family and friends");
        }

        public void DoSomeKindOfNonCultStuff(string stuff) => Console.WriteLine($"Good cult member doing non-cult stuff: {stuff}");


        public override void DoCultStuff()
        {
            Console.WriteLine($"Good cult member doing DoCultStuff");
        }

        public override void ProtectCultLeader()
        {
            Console.WriteLine($"Good cult member doing cult ProtectCultLeader");
        }
    }
}
