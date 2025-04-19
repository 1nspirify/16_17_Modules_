using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Child : Parent
{
    public override void SetSpeed()
    {
        Speed += Speed * Time.deltaTime;
    }

    public override void SomethingHappened()
    {
        base.SomethingHappened();
        Debug.Log("Something happened again");
    }
}