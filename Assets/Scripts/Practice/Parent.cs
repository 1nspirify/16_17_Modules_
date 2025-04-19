using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Parent : MonoBehaviour
{
    protected float Speed = 800f;
    private int _health;

    public virtual void SomethingHappened()
    {
        Debug.Log("Something happened");
    }

    private void Update()
    {
        SomethingHappened();
    }

    public abstract void SetSpeed();
}