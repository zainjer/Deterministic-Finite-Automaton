using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDFA.Core
{
    class Transition
    {
        public State CurrentState { get; init; }
        public Symbol Input { get; init; }
        public State NextState { get; init; }
    }
}
