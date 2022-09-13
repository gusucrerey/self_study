using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.examples.SingleResponsibility
{
    public class BadCultMember : CultMember
    {
        public override string FirstName { get; set; }
        public override string LastName { get; set; }
        public override string CultName { get; set; }

        public BadCultMember(string fname, string lname, string cultname)
        {
            FirstName = fname;
            LastName = lname;
            CultName = cultname;
        }

        public void SomeKindOfNonCultStuff(string stuff) => Console.WriteLine($"Bad cult member doing non-cult stuff: {stuff}");

        public override void DoCultStuff()
        {
            SomeKindOfNonCultStuff("Doing other cultists work because they can");
            Console.WriteLine($"Bad cult member doing cult stuff");
            SomeKindOfNonCultStuff("Starting their own cult");
        }

        public override void ProtectCultLeader()
        {
            SomeKindOfNonCultStuff("Wondering if this cult leader is truly worthy");
            Console.WriteLine($"Bad cult member doing cult stuff");
            SomeKindOfNonCultStuff("Killing cult leader and taking over");
        }
    }
}
