using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIPract.AISystem
{
    public class Miner : BaseGameEntity
    {
        private const int MaxFatigue = 10;

        private float _fatigue;
        private State _currentState;

        public Miner(int id) : base(id) { }

        public override void Update(float deltaTime)
        {
            if (_currentState != null)
            {
                _currentState.Execute(this, deltaTime);
            }
        }

        public void ChangeState(State newState)
        {
            Debug.Assert(_currentState == newState);

            _currentState.Exit(this);
            _currentState = newState;
            _currentState.Enter(this);
        }

        public void InreaseFatigue()
        {
            _fatigue++;
        }

        public void DecreaseFatigue()
        {
            _fatigue--;
        }
    }
}
