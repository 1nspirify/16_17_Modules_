using UnityEngine;

namespace HomeTask
{
    public class ActionRunningOut : IActiveBehaviour
    {
        private Character _character;
        private Enemy _enemy;

        private float _speed = 5f;
        private const float _zero = 0f;

        public ActionRunningOut(Character character, Enemy enemy)
        {
            _character = character;
            _enemy = enemy;
        }

        public void Activate()
        {
            _enemy.transform.position -= GetDirection() * _speed * Time.deltaTime;
        }

        private Vector3 GetDirection()
        {
            Vector3 currentDirection = (_character.transform.position - _enemy.transform.position).normalized;
            Vector3 direction = new Vector3(currentDirection.x, _zero, currentDirection.z).normalized;
            return direction;
        }
    }
}