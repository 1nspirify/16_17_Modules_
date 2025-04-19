using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private EnemyEnumExample _smallEnemyPrefab;
    [SerializeField] private EnemyEnumExample _mediumEnemyPrefab;
    [SerializeField] private EnemyEnumExample _largeEnemyPrefab;

    public void SpawnTo(Vector3 position, EnemyTypes enemyTypes)
    {
       
        
        switch (enemyTypes)
        {
            case EnemyTypes.Small:
                Instantiate(_smallEnemyPrefab, position, Quaternion.identity);
                break;
            case EnemyTypes.Medium:
                Instantiate(_mediumEnemyPrefab, position, Quaternion.identity);
                break;
            case EnemyTypes.Large:
                Instantiate(_largeEnemyPrefab, position, Quaternion.identity);
                break;
            default:
                Debug.Log("There is no such an enemy type");
                break;
        }
    }

    private void Update()
    {
      
    }
}