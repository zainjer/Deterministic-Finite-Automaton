using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDFA.Core
{
    class State
    {
        public State()
        {

        }

        public State(string name,
            bool isStartState = false,
            bool isFinalState = false,
            bool isDeadState = false)
        {
            this.Name = name;
            this.IsStartState = isStartState;
            this.IsFinalState = isFinalState;
            this.IsDeadState = isDeadState;
        }
        public string Name { get; init; }

        public List<Transition> Transitions { get; init; } = new List<Transition>();

        public bool IsStartState { get; init; }

        public bool IsFinalState { get; init; }

        public bool IsDeadState { get; set; }
    }
}
