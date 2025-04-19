using UnityEngine;

namespace HomeTask
{
    public class EnemySpawnPoint : MonoBehaviour
    {
        [SerializeField] private EnumAction _actionTypeBehavior;
        [SerializeField] private EnumIdle _idleTypeBehavior;

        [Space(20)] 
        [SerializeField] private Character _character;
        [SerializeField] private Enemy _enemyPrefab;

        private IActiveBehaviour _iActiveBehaviour;
        private IIdleBehaviour _iIdleBehaviour;

        private IdleChilling _idleChilling;
        private ActionChasing _actionChasing;

        [SerializeField] private ParticleSystem _selfDestroyParticles;

        [SerializeField] private Transform[] _patrolPoints = new Transform[3];

        private void Awake()
        {
            Enemy enemy = CreateEnemy();

            _iActiveBehaviour = ActionBehavior(_actionTypeBehavior, enemy);
            _iIdleBehaviour = IdleBehavior(_idleTypeBehavior, enemy);

            enemy.Initialize(_iActiveBehaviour, _iIdleBehaviour);
        }

        private Enemy CreateEnemy()
        {
            Enemy enemy = Instantiate(_enemyPrefab, transform.position, Quaternion.identity);
            return enemy;
        }

        private IActiveBehaviour ActionBehavior(EnumAction action, Enemy enemy)
        {
            switch (action)
            {
                case EnumAction.Chasing:
                    return new ActionChasing(_character, enemy);

                case EnumAction.RunningOut:
                    return new ActionRunningOut(_character, enemy);

                case EnumAction.SelfDestroy:
                    return new ActionSelfDestroy(enemy, _selfDestroyParticles);

                default:
                    return new ActionChasing(_character, _enemyPrefab);
            }
        }

        private IIdleBehaviour IdleBehavior(EnumIdle idle, Enemy enemy)
        {
            switch (idle)
            {
                case EnumIdle.Chilling:
                    return new IdleChilling(enemy);

                case EnumIdle.Patrolling:
                    return new IdlePatrol(enemy, _patrolPoints);

                case EnumIdle.RandomWalking:
                    return new IdleRandomPatrol(enemy);

                default:
                    return new IdleChilling(enemy);
            }
        }
    }
}