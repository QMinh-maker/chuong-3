using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sosanh : MonoBehaviour
{
    [SerializeField] private bool isEqual;
    [SerializeField] private bool isNotEqual;
    void Start()
    {
        isEqual = (10 == 10); // true 
        isNotEqual = (10 != 5); // true 

        Debug.Log("Is Equal: " + isEqual);
        Debug.Log("Is Not Equal: " + isNotEqual);
    }
}


