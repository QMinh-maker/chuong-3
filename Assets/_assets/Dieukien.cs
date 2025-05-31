using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dieukien : MonoBehaviour
{
    [SerializeField] private int score = 85;
    void Start()
    {
        if (score >= 90)
        {
            Debug.Log("Grade: A");
        }
        else if (score >= 80)
        {
            Debug.Log("Grade: B");
        }
        else
        {
            Debug.Log("Grade: C");
        }
    }
}
