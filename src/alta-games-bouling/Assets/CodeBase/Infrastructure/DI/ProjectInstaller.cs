using CodeBase.Gameplay.Registry;
using Reflex.Core;
using UnityEngine;

namespace CodeBase.Infrastructure.DI
{
    public class ProjectInstaller : MonoBehaviour, IInstaller
    {
        public void InstallBindings(ContainerDescriptor container)
        {
            container.AddSingleton(typeof(Input));
        }
    }
}