using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastingDemo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float originalFloat = 7.8f;
        int castedInt = (int)originalFloat;

        string numberString = "25";
        int parsedInt = int.Parse(numberString);

        Debug.Log("Casted Integer: " + castedInt);
        Debug.Log("Parsed Integer: " + parsedInt);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
