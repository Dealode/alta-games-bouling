using CodeBase.Gameplay.Factory;
using CodeBase.Gameplay.Game.SpawnPoints;
using CodeBase.Gameplay.Registry;
using CodeBase.Infrastructure.StaticData;
using UnityEngine;

namespace CodeBase.Gameplay.Game.States
{
    internal class StartGameState : IGameState
    {
        private readonly GameStateMachine _stateMachine;

        private readonly IRegistryGameObjects _registryGameObjects;
        private readonly IFactory _factory;

        private readonly (ISpawnPoint, ISpawnPoint) _letSpawnRange;
        private readonly ISpawnPoint _sphereSpawnPosition;
        private readonly Vector3 _finishSpawnPosition = new Vector3(0, 0, 0);

        public StartGameState(GameStateMachine stateMachine, IRegistryGameObjects registryGameObjects, IFactory factory, IStaticDataService staticDataService)
        {
            _stateMachine = stateMachine;
            _registryGameObjects = registryGameObjects;
            _factory = factory;
            _sphereSpawnPosition = registryGameObjects.Spheres.spawnPointMainSphere;
        }

        public void Enter()
        {
            _registryGameObjects.Clear();
            
            _registryGameObjects.Spheres.RegisterMainSphere(_factory.CreateMainSphere(_sphereSpawnPosition));
            _registryGameObjects.letRegistry.Register(_factory.CreateLets(_letSpawnRange.Item1, _letSpawnRange.Item2));
            _registryGameObjects.finishRegistry.Register(_factory.CreateFinish(_finishSpawnPosition));
            
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