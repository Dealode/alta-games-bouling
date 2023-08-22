using System;

namespace CodeBase.Gameplay.Game.States
{
    public interface IGameState
    {
        void Enter();
        void Update();
        void Exit();
    }
}