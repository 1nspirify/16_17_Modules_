using UnityEngine;

namespace HomeTask
{
    public class ActionSelfDestroy : IActiveBehaviour
    {
        private Enemy _enemy;
        private ParticleSystem _selfDestroyParticles;

        public ActionSelfDestroy(Enemy enemy, ParticleSystem selfDestroyParticles)
        {
            _enemy = enemy;
            _selfDestroyParticles = selfDestroyParticles;
        }

        public void Activate()
        {
            Object.Destroy(_enemy.gameObject);
            _selfDestroyParticles =
                Object.Instantiate(_selfDestroyParticles, _enemy.transform.position, Quaternion.identity);

            _enemy = null;
        }
    }
}