using UnityEngine;

namespace CodeBase.Gameplay.Game.SpawnPoints
{
    public interface ISpawnPoint
    {
        Transform Transform { get; }
    }
}