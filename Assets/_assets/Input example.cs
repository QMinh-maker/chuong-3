using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private string playerName;
    void Start()
    {
        Debug.Log("Plaer Name: " + playerName);
    }   
}
