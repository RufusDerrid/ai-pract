using System;

namespace AIPract.AISystem
{
    public abstract class State<T> : IEquatable<State<T>>
    {
        protected string _uniqueName;

        public abstract void Enter(T entity);
        public abstract void Execute(T entity, double deltaTime);
        public abstract void Exit(T entity);

        public bool Equals(State<T> other)
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

            State<T> state = other as State<T>;
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

        public static bool operator ==(State<T> state1, State<T> state2)
        {
            if(((object)state1) == null || ((object)state2) == null)
            {
                return Equals(state1, state2);
            }

            return state1.Equals(state2);
        }

        public static bool operator !=(State<T> state1, State<T> state2)
        {
            if (((object)state1) == null || ((object)state2) == null)
            {
                return !Equals(state1, state2);
            }

            return !state1.Equals(state2);
        }
    }
}