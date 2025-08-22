using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringDemo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string firstName = " firstName ";
        string lastName = " lastName ";
        string fullName = firstName + " " + lastName;

        Debug.Log("Full Name: " + fullName);
        Debug.Log("Length: " + fullName.Length);
        Debug.Log("Uppercase: " + fullName.ToUpper());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
