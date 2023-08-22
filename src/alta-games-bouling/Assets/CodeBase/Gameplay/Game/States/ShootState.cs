using System;
using CodeBase.Gameplay.Registry;
using CodeBase.Gameplay.Sphere;

namespace CodeBase.Gameplay.Game.States
{
    public class ShootState : IGameState
    {
        private readonly GameStateMachine _stateMachine;
        private readonly IFinishRegistry _finishRegistry;
        private readonly ISphereRegistry _sphereRegistry;

        public ShootState(GameStateMachine stateMachine, IFinishRegistry finishRegistry, ISphereRegistry sphereRegistry)
        {
            _stateMachine = stateMachine;
            _finishRegistry = finishRegistry;
            _sphereRegistry = sphereRegistry;
        }

        public void Enter()
        {
            var sphere = _sphereRegistry.particleSphere as SphereParticleBehaviour;
            sphere.ShootTo(_finishRegistry.Finish.Position, 10);
            _stateMachine.Enter<WaitUserActionState>();
        }

        public void Update()
        {
        }

        public void Exit()
        {
        }
    }
}