using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Strategy
{
    public class IdleBehavior : IEnemyBehavior
    {
        public void ExecuteBehavior(Enemy enemy)
        {
            enemy.MoveToTargetPosition();
            
            Debug.Log("Idle behavior executing");
        }
    }
}