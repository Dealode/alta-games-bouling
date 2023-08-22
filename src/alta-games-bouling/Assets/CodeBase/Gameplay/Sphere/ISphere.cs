using UnityEngine;

namespace CodeBase.Gameplay.Sphere
{
    public interface ISphere
    {
        float size { get; }
        Vector3 position { get; }
        public void Tick(float deltaTime);
    }
}