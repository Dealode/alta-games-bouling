using System.Collections.Generic;
using CodeBase.Gameplay.Game.SpawnPoints;
using CodeBase.Gameplay.Lets;
using UnityEngine;

namespace CodeBase.Gameplay.Registry
{
    public class LetRegistry : ILetRegistry
    {
        public ISpawnPoint spawnPoint { get; }
        
        public Vector3 SpawnFrom => spawnPoint.Transform.position += new Vector3(0, 0, offsetFrom);
        public Vector3 SpawnTo => spawnPoint.Transform.position += new Vector3(0, 0, offsetTo);
        public float offsetFrom { get; set; }
        public float offsetTo { get; }
        public void Register(IEnumerable<ILets> createLets)
        {
            throw new System.NotImplementedException();
        }

        public void Clear()
        {
            throw new System.NotImplementedException();
        }
    }
}