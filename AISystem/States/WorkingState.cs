using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIPract.AISystem.States
{
    public sealed class WorkingState : State
    {
        private static readonly WorkingState _instance = new WorkingState();

        private WorkingState() { }

        public static WorkingState Instance
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

        public override void Execute(Miner miner, float deltaTime)
        {
            miner.DecreaseFatigue();
        }

        public override void Exit(Miner miner)
        {
            throw new NotImplementedException();
        }
    }
}
