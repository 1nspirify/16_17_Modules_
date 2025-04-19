// using System;
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
//
// public struct ExampleStruct
// {
//     private int position;
//
//     public void Add(Vector3 value)
//     {
//     }
//
//
//     public void AddTo(ExampleStruct exampleStruct, int value)
//     {
//     }
// }
//
// public class ExampleClass : MonoBehaviour
// {
//     ExampleStruct _exampleStruct = new ExampleStruct();
//
//     private GameObject _gameObject;
//
//     private void Update()
//     {
//         {
//             if (Input.GetKey(KeyCode.Space))
//             {
//                 _exampleStruct.Add(Vector3.up);
//             }
//         }
//         _gameObject.transform.rotation = Quaternion.LookRotation(Vector3.forward);
//     }
//
//     private EnemyTypes enemyTypes = EnemyTypes.Large;
// }