using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IExample
{
    int Property { get; }
    void Method();
}

public interface IExample2
{
    int Property { get; }
    void Method();
}

public class Example : IExample ,IExample2
{
    public int Property { get; }

    public void Method()
    {
        Debug.Log("Method called");
    }
}