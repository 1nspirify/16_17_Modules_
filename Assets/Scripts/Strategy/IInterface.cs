using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Strategy
{
    public interface IEnemyBehavior
    {
        void ExecuteBehavior(Enemy enemy);
    }
}