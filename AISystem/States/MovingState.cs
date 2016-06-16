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
            throw new NotImplementedException();
        }

        public override void Execute(Miner miner)
        {
            throw new NotImplementedException();
        }

        public override void Exit(Miner miner)
        {
            throw new NotImplementedException();
        }
    }
}
