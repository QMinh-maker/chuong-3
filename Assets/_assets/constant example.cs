using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class constantexample : MonoBehaviour
{
    // Start is called before the first frame update
    private const float PI = 3.14f;
    private const float Days_in_week = 7;
    void Start()
    {
        Debug.Log("PI: " + PI);
        Debug.Log("Days in a week: " + Days_in_week);
    }
}
