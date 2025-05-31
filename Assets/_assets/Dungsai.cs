using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dieukien : MonoBehaviour
{
    [SerializeField] private bool andResult;
    [SerializeField] private bool orResult;
    [SerializeField] private bool notResult;
    void Start()
    {
        andResult = (true && false); // false 
        orResult = (true || false); // true 
        notResult = !true; // false

        Debug.Log("AND Result: " + andResult);
        Debug.Log("OR Result: " + orResult);
        Debug.Log("NOT Result: " + notResult);
    }
}
