using CodeBase.Gameplay.Registry;
using CodeBase.Gameplay.Ticks;
using CodeBase.Gameplay.UserInput;
using Reflex.Attributes;
using UnityEngine;

namespace CodeBase.Gameplay.Game.States
{
    public class AccumulatePowerState : IGameState
    {
        private readonly ITickService _tickService;
        private readonly ITouchAction _touchAction;
        private readonly GameStateMachine _stateMachine;
        private readonly ISphereRegistry _sphereRegistry;

        public AccumulatePowerState(ITickService tickService, ITouchAction touchAction, GameStateMachine stateMachine, ISphereRegistry sphereRegistry)
        {
            _tickService = tickService;
            _touchAction = touchAction;
            _stateMachine = stateMachine;
            _sphereRegistry = sphereRegistry;
        }
        
        public void Enter()
        {
            _touchAction.EndHold += OnTouchEndHold;
        }

        public void Update()
        {
            SphereSizeTick();
            CheckGameEnd();
        }

        public void Exit()
        {
            _touchAction.EndHold -= OnTouchEndHold;
        }
        
        
        private void OnTouchEndHold() => 
            _stateMachine.Enter<ShootState>();
        
        private void SphereSizeTick()
        {
            _tickService.Tick(Time.deltaTime);
        }

        private void CheckGameEnd()
        {
            if (_sphereRegistry.mainSphere.size < 0.1f)
                _stateMachine.Enter<EndGameState>();
        }

    }
}