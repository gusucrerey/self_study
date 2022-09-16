using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.examples.SingleResponsibility
{
    public interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
    }
}
