using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchexample: MonoBehaviour
{
    [SerializeField] private int day = 3;
    void Start()
    {
        switch (day)
        {
            case 1:
                Debug.Log("Monday");
                break;
            case 2:
                Debug.Log("Tuesday");
                break;
            case 3:
                Debug.Log("Wednesday");
                break;
            default:
                Debug.Log("Other day");
                break;
        }
    }
}


