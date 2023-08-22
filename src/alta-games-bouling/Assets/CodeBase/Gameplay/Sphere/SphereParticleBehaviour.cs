using System;
using UnityEngine;

namespace CodeBase.Gameplay.Sphere
{
    [RequireComponent(typeof(Rigidbody))]
    public class SphereParticleBehaviour : SphereBehaviour, IParticle
    {
        private Rigidbody _rigidbody;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        public override void Tick(float deltaTime)
        {
            size += deltaTime;
        }

        public void ShootTo(Vector3 target, float speed)
        {
            _rigidbody.velocity = (target - transform.position).normalized * speed;
        }
    }
}