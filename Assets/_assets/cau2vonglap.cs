using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cau2vonglap : MonoBehaviour
{
    public int n = 0;
    void Start()
    {
        for (int i = 1; i < 11; i++)
        {
            int tich = n * i;
            Debug.Log(tich);
        }
    }

    
    
}
