using CodeBase.Gameplay.Factory;
using CodeBase.Gameplay.Game.States;
using CodeBase.Gameplay.Registry;
using CodeBase.Gameplay.Ticks;
using CodeBase.Gameplay.UserInput;
using CodeBase.Infrastructure.StaticData;
using Reflex.Attributes;
using UnityEngine;

namespace CodeBase.Gameplay.Game
{
    public class GameStarter : MonoBehaviour
    {
        private GameStateMachine _stateMachine;

        [Inject]
        private void Constructor(IRegistryGameObjects registryGameObjects, IFactory factory, IStaticDataService staticDataService,
                                 ITouchAction touchAction, ITickService tickService)
        {
            _stateMachine = new GameStateMachine(registryGameObjects, factory, staticDataService, touchAction, tickService);
        }
        
        private void Start()
        {
            _stateMachine.Enter<StartGameState>();
        }
    }
}