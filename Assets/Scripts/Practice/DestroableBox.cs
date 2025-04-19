using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroableBox : MonoBehaviour, IInteractable
{
    private float _currentScale;

    private bool isInteracted;

    public void Interact()
    {
        isInteracted = true;
    }

    private void Awake()
    {
        _currentScale = transform.localScale.x;
    }

    private void Update()
    {
        if (isInteracted)
        {
            _currentScale -= Time.deltaTime * 10;
            
            transform.localScale = new Vector3(_currentScale, _currentScale, _currentScale);
            if (_currentScale <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}