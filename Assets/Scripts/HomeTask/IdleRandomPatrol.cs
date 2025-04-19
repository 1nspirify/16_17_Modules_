using UnityEngine;

namespace HomeTask
{
    public class IdleRandomPatrol : IIdleBehaviour
    {
        private Transform _enemy;
        
        private float _time;
        private float _direction;
        private float _speed = 2f;

        private const float _timeSign = 1f;
        private const float _timeZeroSign = 0f;
        private const float _zero = 0f;
        private const float _maxValue = 360f;
        
        
        public IdleRandomPatrol(Enemy enemy)
        {
            _enemy = enemy.transform;
        }

        public void Idle()
        {
            if (_time == _timeZeroSign)
            {
                ChangeDirection();
            }

            _time += Time.deltaTime;
            
            Move();
            
            if (_time >= _timeSign)
            {
                ChangeDirection();
                _time = _timeZeroSign;
            }
        }

        private float GetDirection()
        {
            float _randomRotationY = Random.Range(_zero, _maxValue);
            return _randomRotationY;
        }

        private void ChangeDirection()
        {
            _direction = GetDirection();
            _enemy.transform.rotation = Quaternion.Euler(_zero, _direction, _zero);
        }

        private void Move()
        {
            _enemy.Translate(Vector3.forward * _speed * Time.deltaTime);
        }
    }
}