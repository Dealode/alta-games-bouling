using UnityEngine;

namespace CodeBase.Gameplay.Sphere
{
    public abstract class SphereBehaviour : MonoBehaviour, ISphere
    {
        public float size { get; set; }
        public Vector3 position { get; }

        public abstract void Tick(float deltaTime);
    }
}