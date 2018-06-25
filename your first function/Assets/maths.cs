using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maths : MonoBehaviour
{
    public float a;
    public float b;

    // Use this for initialization
    void sum()
    {
        Debug.Log(a + b);
    }
    void substract()
    {
        Debug.Log(a - b);
    }
    void multiplication()
    {
        Debug.Log(a * b);
    }
    void Start()
    {
        sum();
        substract();
        multiplication();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
