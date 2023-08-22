namespace CodeBase.Gameplay.Registry
{
    public interface IRegistryGameObjects
    {
        public ISphereRegistry Spheres { get; }
        public IFinishRegistry finishRegistry { get; }
        public ILetRegistry letRegistry { get; }
        void Clear();
    }
}