using System.Collections.Generic;
using CodeBase.Gameplay.Factory;
using CodeBase.Gameplay.Game.SpawnPoints;

namespace CodeBase.Gameplay.Registry
{
    public interface IFinishRegistry
    {
        ISpawnPoint FinishTransform { get; }
        IFinish Finish { get; }
        void Register(IEnumerable<IFinish> createFinish);
        void Clear();
    }

    class FinishRegistry : IFinishRegistry
    {
        public ISpawnPoint FinishTransform { get; }
        public IFinish Finish { get; }
        public void Register(IEnumerable<IFinish> createFinish)
        {
            throw new System.NotImplementedException();
        }

        public void Clear()
        {
            throw new System.NotImplementedException();
        }
    }
}