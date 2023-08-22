using System.Collections.Generic;
using CodeBase.Gameplay.Game.SpawnPoints;
using CodeBase.Gameplay.Lets;
using CodeBase.Gameplay.Sphere;
using CodeBase.Infrastructure.StaticData;
using UnityEngine;

namespace CodeBase.Gameplay.Factory
{
    public class Factory : IFactory
    {
        private readonly IStaticDataService _staticDataService;

        public Factory(IStaticDataService staticDataService)
        {
            _staticDataService = staticDataService;
        }

        public SphereParticleBehaviour CreateParticleSphere()
        {
            throw new System.NotImplementedException();
        }

        public SphereBehaviour CreateMainSphere(ISpawnPoint spawnPoint) =>
            Object.Instantiate(Resources.Load<SphereBehaviour>(_staticDataService.sphereMainAssetPath), spawnPoint.Transform, false);

        public IEnumerable<ILets> CreateLets(ISpawnPoint spawnFrom, ISpawnPoint spawnTo)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<IFinish> CreateFinish(Vector3 finishSpawnPosition)
        {
            throw new System.NotImplementedException();
        }
    }
}