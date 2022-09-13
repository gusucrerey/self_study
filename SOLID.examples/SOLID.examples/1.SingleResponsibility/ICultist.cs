using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.examples.SingleResponsibility
{
    public interface ICultist
    {
        string CultName { get; set; }
        void DoCultStuff();
        void ProtectCultLeader();
    }
}
