using System;
using System.Collections.Generic;
using CodeBase.Gameplay.Factory;
using CodeBase.Gameplay.Game.States;
using CodeBase.Gameplay.Registry;
using CodeBase.Gameplay.Ticks;
using CodeBase.Gameplay.UserInput;
using CodeBase.Infrastructure.StaticData;
using UnityEngine;

namespace CodeBase.Gameplay.Game
{
    public class GameStateMachine
    {
        private Dictionary<Type, IGameState> _states;
        private IGameState _activeState;

        public GameStateMachine(IRegistryGameObjects registryGameObjects, IFactory factory, IStaticDataService staticDataService,
                                ITouchAction touchAction, ITickService tickService)
        {
            _states = new Dictionary<Type, IGameState>
            {
                [typeof(StartGameState)] = new StartGameState(this, registryGameObjects, factory, staticDataService),
                [typeof(WaitUserActionState)] = new WaitUserActionState(registryGameObjects.Spheres, tickService, touchAction, this, factory),
                [typeof(AccumulatePowerState)] = new AccumulatePowerState(tickService, touchAction, this, registryGameObjects.Spheres),
                [typeof(ShootState)] = new ShootState(this, registryGameObjects.finishRegistry, registryGameObjects.Spheres)
            };
        }
        
        public void Enter<TState>() where TState : class, IGameState
        {
            ChangeState<TState>().Enter();
        }
        
        private TState ChangeState<TState>() where TState : class, IGameState
        {
            _activeState?.Exit();

            var state = GetState<TState>();
            Debug.Log("Enter state: " + state.GetType().Name);
            _activeState = state;

            return state;
        }

        private TState GetState<TState>() where TState : class, IGameState => 
            _states[typeof(TState)] as TState;
    }
}