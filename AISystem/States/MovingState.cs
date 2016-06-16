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

        private MovingState() { }

        public static MovingState Instance
        {
            get
            {
                return _instance;
            }
        }

        public override void Enter(Miner miner)
        {
            _targetPosition = new Vector2(100, 100);
            _moveVector = _targetPosition - miner.Position;
            _moveVector.Normalize();
        }

        public override void Execute(Miner miner, double deltaTime)
        {
            miner.AddPosition(miner.Position + _moveVector * (float)deltaTime);
        }

        public override void Exit(Miner miner)
        {
            throw new NotImplementedException();
        }
    }
}
