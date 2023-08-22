using CodeBase.Gameplay.Factory;
using CodeBase.Gameplay.Registry;
using CodeBase.Gameplay.Ticks;
using CodeBase.Gameplay.UserInput;
using UnityEngine;

namespace CodeBase.Gameplay.Game.States
{
    class WaitUserActionState : IGameState
    {
        private readonly GameStateMachine _stateMachine;
        private readonly IFactory _factory;
        private readonly ISphereRegistry _sphereRegistry;
        private readonly ITouchAction _touchAction;

        public WaitUserActionState(ISphereRegistry sphereRegistry, ITickService tickService, ITouchAction touchAction, GameStateMachine stateMachine, IFactory factory)
        {
            _sphereRegistry = sphereRegistry;
            _touchAction = touchAction;
            _stateMachine = stateMachine;
            _factory = factory;
        }

        public void Enter()
        {
           _touchAction.StartHold += OnTouchStartHold;
        }

        public void Update()
        {
        }

        public void Exit()
        {
            _touchAction.StartHold -= OnTouchStartHold;
        }

        private void OnTouchStartHold()
        {
            _sphereRegistry.RegisterParticleSphere(
                _factory.CreateParticleSphere());
            _stateMachine.Enter<AccumulatePowerState>();
        }


    }
}