using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toan : MonoBehaviour
{
    [SerializeField] private int tong;
    [SerializeField] private int hieu;
    [SerializeField] private int tich;
    [SerializeField] private int thuongchia;
    [SerializeField] private int thuongdu;


    // Start is called before the first frame update
    void Start()
    {
        tong = 11 + 1;
        hieu = 11 - 1;
        tich = 11 * 1;
        thuongchia = 11 / 1;
        thuongdu = 11 % 1;
        Debug.Log("Sum: " + tong);
        Debug.Log("Difference: " + hieu);
        Debug.Log("Product: " + tich);
        Debug.Log("Quotient: " + thuongchia);
        Debug.Log("Remainder: " + thuongdu);
    }

}
