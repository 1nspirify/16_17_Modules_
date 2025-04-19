using System.Collections.Generic;
using UnityEngine;

namespace HomeTask
{
    public class IdlePatrol : IIdleBehaviour
    {
        private Transform _enemy;

        private float _speed = 2f;

        private float _direction;

        private float _minValue = 0.1f;

        private Transform[] _patrolPoints;

        private Vector3 _currentPoint;

        private Queue<Vector3> _currentPatrolPoints = new Queue<Vector3>();

        public IdlePatrol(Enemy enemy, Transform[] patrolPoints)
        {
            _enemy = enemy.transform;
            _patrolPoints = patrolPoints;

            foreach (var point in _patrolPoints)
            {
                _currentPatrolPoints.Enqueue(point.position);
            }

            _currentPoint = _currentPatrolPoints.Peek();
        }

        public void Idle()
        {
            Vector3 direction = (_currentPoint - _enemy.position).normalized;

            _enemy.position += direction * _speed * Time.deltaTime;

            float distance = Vector3.Distance(_enemy.position, _currentPoint);

            if (distance <= _minValue)
                SwitchPatrolPoint();
        }
        
        private void SwitchPatrolPoint()
        {
            _currentPatrolPoints.Enqueue(_currentPatrolPoints.Dequeue());
            _currentPoint = _currentPatrolPoints.Peek();
        }
    }
}