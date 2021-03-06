﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIPract.AISystem.States
{
    public sealed class RestingState : State<Miner>
    {
        private static readonly RestingState _instance = new RestingState();

        private RestingState()
        {
            _uniqueName = "RestingState";
        }

        public static RestingState Instance
        {
            get
            {
                return _instance;
            }
        }

        public override void Enter(Miner miner)
        {
            miner.State = "resting";
        }

        public override void Execute(Miner miner, float deltaTime)
        {
            miner.InreaseFatigue(4 * deltaTime);
            if (miner.Fatigue >= Miner.MaxFatigue)
            {
                miner.StateMachine.ChangeState(MovingState.Instance);
            }
        }

        public override void Exit(Miner miner)
        {
            
        }
    }
}
