namespace CodeBase.Gameplay.Sphere
{
    public class SphereMainBehaviour : SphereBehaviour
    {
        public override void Tick(float deltaTime)
        {
            size -= deltaTime / 2;
        }
    }
}