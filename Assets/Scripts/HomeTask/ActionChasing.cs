using UnityEngine;

namespace HomeTask
{
    public class ActionChasing : IActiveBehaviour
    {
        private Character _character;
        private Enemy _enemy;

        private float _speed = 3f;  
        private const float _zero = 0f;

        public ActionChasing(Character character, Enemy enemy)
        {
            _character = character;
            _enemy = enemy;
        }

        public void Activate()
        {
            Chase();
        }

        private Vector3 GetDirection()
        {
            Vector3 currentDirection = (_character.transform.position - _enemy.transform.position).normalized;
            Vector3 direction = new Vector3(currentDirection.x, _zero, currentDirection.z).normalized;
            return direction;
        }

        private void Chase()
        {
            _enemy.transform.position += GetDirection() * _speed * Time.deltaTime;
        }
    }
}