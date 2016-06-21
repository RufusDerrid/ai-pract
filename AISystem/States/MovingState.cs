using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIPract.AISystem.States
{
    public sealed class MovingState : State
    {
        private static readonly MovingState _instance = new MovingState();

        private Vector2 _targetPosition;
        private Vector2 _moveVector;

        private MovingState()
        {
            _uniqueName = "MovingState";
        }

        public static MovingState Instance
        {
            get
            {
                return _instance;
            }
        }

        public override void Enter(Miner miner)
        {
            if (miner.State == "start" || miner.State == "resting")
            {
                _targetPosition = new Vector2(100, 100);
            }
            else if (miner.State == "working")
            {
                _targetPosition = Vector2.Zero;
            }

            _moveVector = _targetPosition - miner.Position;
            _moveVector.Normalize();
        }

        public override void Execute(Miner miner, double deltaTime)
        {
            var delta = _moveVector * (float)deltaTime * 2;
            miner.AddPosition(_moveVector);
            var length = (_targetPosition - miner.Position).Length();
            if (length < 10.0f)
            {
                if (miner.State == "resting" || miner.State == "start")
                {
                    miner.ChangeState(WorkingState.Instance);
                }
                else if (miner.State == "working")
                {
                    miner.ChangeState(RestingState.Instance);
                }
            }
        }

        public override void Exit(Miner miner)
        {
            
        }
    }
}
