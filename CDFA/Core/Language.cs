using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDFA.Core
{
    class Language
    {
        public Language(List<Symbol> symbolSet)
        {
            SymbolSet = symbolSet;
        }
        public List<Symbol> SymbolSet { get; init; }

        public List<State> States { get; set; }
    }
}
