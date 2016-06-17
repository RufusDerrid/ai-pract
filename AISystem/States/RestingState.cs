﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIPract.AISystem.States
{
    public sealed class RestingState : State
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
            
        }

        public override void Execute(Miner miner, double deltaTime)
        {
            
        }

        public override void Exit(Miner miner)
        {
            
        }
    }
}
