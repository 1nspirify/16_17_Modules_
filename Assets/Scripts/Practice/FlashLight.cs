using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour, IInteractable
{
    [SerializeField] private Light _light;

    private void Awake()
    {
        _light = GetComponent<Light>();
    }

    public void Interact()
    {
        _light.enabled = !_light.enabled;
    }
}