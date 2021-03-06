﻿using AIPract.AISystem.States;
using Microsoft.Xna.Framework;
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
        public const int MaxFatigue = 10;

        public string State;
        public Vector2 Position { get; private set; }
        public float Fatigue { get { return _fatigue; } }
        public StateMachine<Miner> StateMachine { get { return _stateMachine; } }

        private float _fatigue;
        private StateMachine<Miner> _stateMachine;

        public Miner(int id) : base(id)
        {
            Position = Vector2.Zero;
            State = "start";
            _fatigue = 10;
            _stateMachine = new StateMachine<Miner>(this);
            _stateMachine.SetCurrentState(MovingState.Instance);
        }

        public override void Update(float deltaTime)
        {
            _stateMachine.Update(deltaTime);
        }

        public void RevertToPreviousState()
        {

        }

        public void AddPosition(Vector2 pos)
        {
            Position += pos;
        }

        public void InreaseFatigue(float deltaTime)
        {
            _fatigue += deltaTime;
        }

        public void DecreaseFatigue(float deltaTime)
        {
            _fatigue -= deltaTime;
        }
    }
}
