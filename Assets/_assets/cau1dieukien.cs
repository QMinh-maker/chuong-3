using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cau1dieukien : MonoBehaviour
{
    [SerializeField] public int diemso = 0;
    void Start()
    {
        if (diemso >= 8)
        {
            Debug.Log("HOC SINH GIOI.");
        }
        else if (diemso >= 6)
        {
            Debug.Log("HOC SINH TIEN TIEN.");
        }
        else if(diemso >= 4)
        {
            Debug.Log("HOC SINH TRUNG BINH.");
        }
        else if(diemso >= 0)
        {
            Debug.Log("HOC SINH YEU.");
        }
    } 
}
