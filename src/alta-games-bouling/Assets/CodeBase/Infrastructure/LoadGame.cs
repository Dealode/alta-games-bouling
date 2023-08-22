using System;
using CodeBase.Gameplay.Factory;
using CodeBase.Gameplay.Registry;
using CodeBase.Gameplay.Ticks;
using CodeBase.Gameplay.UserInput;
using CodeBase.Infrastructure.DI.Extension;
using CodeBase.Infrastructure.StaticData;
using Reflex.Core;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CodeBase.Infrastructure
{
    public class LoadGame : MonoBehaviour
    {
        void Start()
        {
            ReflexSceneManager.LoadScene("Game", LoadSceneMode.Single, descriptor =>
            {
                descriptor.AddInstance(new Input());
                descriptor.BindDisposable<ITouchAction, TouchAction>();
                descriptor.Bind<IStaticDataService, StaticDataService>();
                descriptor.Bind<IFactory, Factory>();
                descriptor.Bind<IRegistryGameObjects, RegistryGameObjects>();
                descriptor.Bind<ITickService, TickService>();
            });
        }

        
    }
}
