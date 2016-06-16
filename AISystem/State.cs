using System;

namespace AIPract.AISystem
{
    public abstract class State : IEquatable<State>
    {
        protected string _uniqueName;

        public abstract void Enter(Miner miner);
        public abstract void Execute(Miner miner, float deltaTime);
        public abstract void Exit(Miner miner);

        public bool Equals(State other)
        {
            if (other == null)
                return false;

            if (_uniqueName == other._uniqueName)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public override bool Equals(object other)
        {
            if (other == null)
                return false;

            State state = other as State;
            if (state == null)
            {
                return false;
            }
            else
            {
                return Equals(state);
            }
        }

        public override int GetHashCode()
        {
            return _uniqueName.GetHashCode();
        }

        public static bool operator ==(State state1, State state2)
        {
            if(((object)state1) == null || ((object)state2) == null)
            {
                return Equals(state1, state2);
            }

            return state1.Equals(state2);
        }

        public static bool operator !=(State state1, State state2)
        {
            if (((object)state1) == null || ((object)state2) == null)
            {
                return !Equals(state1, state2);
            }

            return !state1.Equals(state2);
        }
    }
}