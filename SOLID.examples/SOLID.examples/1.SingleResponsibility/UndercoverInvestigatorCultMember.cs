using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.examples.SingleResponsibility
{
    public class UndercoverInvestigatorCultMember : CultMember, IInvestigator
    {
        public override string FirstName { get; set; }
        public override string LastName { get; set; }
        public override string CultName { get; set; }
        public bool HasIncriminatingEvidence { get; set; }

        public UndercoverInvestigatorCultMember(string fname, string lname, string cultname)
        {
            FirstName = fname;
            LastName = lname;
            CultName = cultname;
            HasIncriminatingEvidence = false;

            SomeKindOfNonCultStuff("Starting undrcover work.");
        }

        public void SomeKindOfNonCultStuff(string stuff) => Console.WriteLine($"Undercover Investigator cult member doing non-cult stuff: {stuff}");
        public void ReportOnCult() => ReportDiscoveries();

        public override void DoCultStuff()
        {
            Console.WriteLine($"Undercover Investigator cult member doing DoCultStuff");
            DigDeeperForInformation();
            if (HasIncriminatingEvidence)
                ReportOnCult();
        }

        public override void ProtectCultLeader()
        {
            Console.WriteLine($"Undercover Investigator cult member doing ProtectCultLeader");
            DigDeeperForInformation();
            if(HasIncriminatingEvidence)
                ReportOnCult();
        }

        public void DigDeeperForInformation()
        {
            SomeKindOfNonCultStuff("Digging for more information...");
        }

        public void ReportDiscoveries()
        {
            SomeKindOfNonCultStuff("Reporting crimes to police and/or press");
        }
    }
}
