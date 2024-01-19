using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IctFest
{
    public interface IEventWithElimination
    {
        bool IsEliminated { get; }
        void Eliminate();
    }
}
