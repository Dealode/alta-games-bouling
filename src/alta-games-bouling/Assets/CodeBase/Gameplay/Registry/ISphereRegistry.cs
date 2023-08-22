using System.Collections.Generic;
using CodeBase.Gameplay.Game.SpawnPoints;
using CodeBase.Gameplay.Sphere;

namespace CodeBase.Gameplay.Registry
{
    public interface ISphereRegistry
    {
        ISpawnPoint spawnPointMainSphere { get; }
        ISphere mainSphere { get; set; }
        ISphere particleSphere { get; set; }
        
        void RegisterMainSphere(SphereBehaviour sphere);
        void RegisterParticleSphere(SphereBehaviour sphere);
        void Clear();
    }
}