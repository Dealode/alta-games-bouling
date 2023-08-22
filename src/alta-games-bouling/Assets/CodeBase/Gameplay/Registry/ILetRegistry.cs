using System.Collections.Generic;
using CodeBase.Gameplay.Game.SpawnPoints;
using CodeBase.Gameplay.Lets;
using UnityEngine;

namespace CodeBase.Gameplay.Registry
{
    public interface ILetRegistry
    {
        ISpawnPoint spawnPoint { get; }
        Vector3 SpawnFrom { get; }
        Vector3 SpawnTo { get; }
        float offsetFrom { get; set; }
        float offsetTo { get; }
        void Register(IEnumerable<ILets> createLets);
        void Clear();
    }
}