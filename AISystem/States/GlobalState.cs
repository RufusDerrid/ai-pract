using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIPract.AISystem.States
{
    public class GlobalState : State<Miner>
    {
        public override void Enter(Miner miner)
        {
            miner.State = "global";
        }

        public override void Execute(Miner miner, float deltaTime)
        {
            
        }

        public override void Exit(Miner miner)
        {
            
        }
    }
}
