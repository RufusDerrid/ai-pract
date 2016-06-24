using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIPract.AISystem.States
{
    public sealed class WorkingState : State<Miner>
    {
        private static readonly WorkingState _instance = new WorkingState();

        private WorkingState()
        {
            _uniqueName = "WorkingState";
        }

        public static WorkingState Instance
        {
            get
            {
                return _instance;
            }
        }

        public override void Enter(Miner miner)
        {
            miner.State = "working";
        }

        public override void Execute(Miner miner, float deltaTime)
        {
            miner.DecreaseFatigue(4*deltaTime);
            if(miner.Fatigue <= 0)
            {
                miner.InreaseFatigue(1);
                miner.StateMachine.ChangeState(MovingState.Instance);
            }
        }

        public override void Exit(Miner miner)
        {
            
        }
    }
}
