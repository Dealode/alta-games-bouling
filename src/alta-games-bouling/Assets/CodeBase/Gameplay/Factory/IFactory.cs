using System.Collections.Generic;
using CodeBase.Gameplay.Game.SpawnPoints;
using CodeBase.Gameplay.Lets;
using CodeBase.Gameplay.Sphere;
using UnityEngine;

namespace CodeBase.Gameplay.Factory
{
    public interface IFactory
    {
        SphereParticleBehaviour CreateParticleSphere();
        SphereBehaviour CreateMainSphere(ISpawnPoint sphereSpawnPosition);
        IEnumerable<ILets> CreateLets(ISpawnPoint spawnFrom, ISpawnPoint spawnTo);
        IEnumerable<IFinish> CreateFinish(Vector3 finishSpawnPosition);
    }
}