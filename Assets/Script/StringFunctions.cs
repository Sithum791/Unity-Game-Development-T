using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string playerName = "Kavindu Silva";
        Debug.Log("Name: " + playerName);
        Debug.Log("Uppercase: " + playerName.ToUpper());
        Debug.Log("Character Count: " + playerName.Length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
