using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccessSystem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //declare variable
        int age = 18;
        bool hasID = true;
      
        if (age >= 18 && hasID)
        {
            Debug.Log("Entry allowed.");
        }
        else
        {
            Debug.Log("Entry denied.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
