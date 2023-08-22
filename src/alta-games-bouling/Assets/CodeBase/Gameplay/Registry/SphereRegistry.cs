using CodeBase.Gameplay.Game.SpawnPoints;
using CodeBase.Gameplay.Sphere;

namespace CodeBase.Gameplay.Registry
{
    public class SphereRegistry : ISphereRegistry
    {
        public ISpawnPoint spawnPointMainSphere { get; }
        public ISphere mainSphere { get; set; }
        public ISphere particleSphere { get; set; }
        public void RegisterMainSphere(SphereBehaviour sphere)
        {
            throw new System.NotImplementedException();
        }

        public void RegisterParticleSphere(SphereBehaviour sphere)
        {
            throw new System.NotImplementedException();
        }

        public void Clear()
        {
            throw new System.NotImplementedException();
        }
    }
}