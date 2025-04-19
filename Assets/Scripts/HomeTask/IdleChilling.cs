using UnityEngine;

namespace HomeTask
{
    public class IdleChilling : IIdleBehaviour
    {
        private Enemy _enemy;
        
        private float _time;

        private float _angleY;
        
        private const float _zero = 0f;

        public IdleChilling(Enemy enemy)
        {
            _enemy = enemy;
        }

        public void Idle()
        {
            _time += Time.deltaTime;
            _enemy.transform.rotation = Quaternion.Euler(_zero, _angleY * _time, _zero);
        }
    }
}