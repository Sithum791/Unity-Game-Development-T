using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooleanDemo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Declare boolean variables
        bool isLoggedIn = true;
        bool hasAccess = false;
       
        if (isLoggedIn && hasAccess)
        {
            Debug.Log("Access granted.");
        }
        else
        {
            Debug.Log("Access denied.");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
