namespace CodeBase.Gameplay.Registry
{
    public class RegistryGameObjects : IRegistryGameObjects
    {
        public ISphereRegistry Spheres { get; }

        public IFinishRegistry finishRegistry { get; }

        public ILetRegistry letRegistry { get; }

        public RegistryGameObjects()
        {
            Spheres = new SphereRegistry();
            finishRegistry = new FinishRegistry();
            letRegistry = new LetRegistry();
        }

        public void Clear()
        {
            Spheres.Clear();
            finishRegistry.Clear();
            letRegistry.Clear();
        }
    }
}