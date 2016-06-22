using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIPract.AISystem
{
    public class StateMachine<T>
    {
        public State<T> CurrentState { get { return _currentState; } }
        public State<T> PreviousState { get { return _previousState; } }
        public State<T> GlobalState { get { return _globalState; } }

        private T _owner;
        private State<T> _currentState;
        private State<T> _previousState;
        private State<T> _globalState;

        public void SetCurrentState(State<T> s)
        {
            _currentState = s;
        }

        public void SetGlobalState(State<T> s)
        {
            _globalState = s;
        }

        public void SetPreviousState(State<T> s)
        {
            _previousState = s;
        }

        public void Update(double deltaTime)
        {
            if (_globalState != null)
            {
                _globalState.Execute(_owner, deltaTime);
            }

            if (_currentState != null)
            {
                _currentState.Execute(_owner, deltaTime);
            }
        }

        public void ChangeState(State<T> newState)
        {
            Debug.Assert(newState != null);

            _previousState = _currentState;
            _currentState.Exit(_owner);
            _currentState = newState;
            _currentState.Enter(_owner);
        }

        public void RevertToPreviousState()
        {
            ChangeState(_previousState);
        }
    }
}
