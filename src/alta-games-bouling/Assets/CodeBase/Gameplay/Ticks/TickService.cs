using CodeBase.Gameplay.Registry;

namespace CodeBase.Gameplay.Ticks
{
    public class TickService : ITickService
    {
        private readonly ISphereRegistry _sphereRegistry;

        public TickService(IRegistryGameObjects registryGameObjects)
        {
            _sphereRegistry = registryGameObjects.Spheres;
        }

        public void Tick(float deltaTime)
        {
            _sphereRegistry.mainSphere.Tick(deltaTime);
            _sphereRegistry.particleSphere.Tick(deltaTime);
        }
    }
}