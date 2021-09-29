using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDFA.Core
{
    class DFA
    {
        public Language Language { get; set; }

        public List<string> Inputs { get; set; }

        public List<State> States { get; set; }
        
    }
}
