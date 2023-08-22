using UnityEngine;

namespace CodeBase.Gameplay.Sphere
{
    public interface IParticle
    {
        void ShootTo(Vector3 target, float speed);
    }
}