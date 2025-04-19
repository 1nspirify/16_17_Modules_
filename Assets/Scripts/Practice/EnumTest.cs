using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnumTest : MonoBehaviour
{
    [SerializeField] private EnemySpawner _spawner;
    [SerializeField] Vector3 _position;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _spawner.SpawnTo(_position, EnemyTypes.Small);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _spawner.SpawnTo(_position, EnemyTypes.Medium);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _spawner.SpawnTo(_position, EnemyTypes.Large);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            int enemyTypesCount = Enum.GetValues(typeof(EnemyTypes)).Length;
            EnemyTypes randEnemyType = (EnemyTypes)Random.Range(0, enemyTypesCount);
            _spawner.SpawnTo(_position, randEnemyType);
        }
    }
}