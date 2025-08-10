using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginCheck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool isLoggedIn = true;
        bool isAdmin = false;
        if (isLoggedIn && isAdmin)
        {
            Debug.Log("Welcome, Admin");
        }
        else if (isLoggedIn)
        {
            Debug.Log("Welcome, User");
        }
        else
        {
            Debug.Log("Access Denied");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
