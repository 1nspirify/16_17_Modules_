using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instansiator : MonoBehaviour
{
    [SerializeField] private GameObject _cube;
    [SerializeField] private int _columns = 5;
    [SerializeField] private int _rows = 5;
    private Renderer _renderer;
    
    [SerializeField] Vector3 _step;
    
    private void Awake()
    {
       // CreateBoxes();
    }
    
    [ContextMenu("Create Boxes")]
    private void CreateBoxes()
    {
        for (int i = 0; i < _columns; i++)
        {
            for (int j = 0; j < _rows; j++)
            {
                Vector3 position = new Vector3(i * _step.x, 0, j * _step.z);
                GameObject cube = Instantiate(_cube, position, Quaternion.identity);
                cube.transform.parent = transform;

                Renderer cubeRenderer = cube.GetComponent<Renderer>();

                if (cubeRenderer != null)
                {
                    cubeRenderer.material = new Material(cubeRenderer.material);
                    
                    if ((i + j) % 2 == 0)
                    {
                        cubeRenderer.material.color = Color.blue;
                    }
                    else
                    {
                        cubeRenderer.material.color = Color.white;
                    }
                }
            }
        }
    }
}