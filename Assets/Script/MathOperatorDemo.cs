using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathOperatorDemo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 10;
        int b = 4;
        Debug.Log("Addition: " + (a + b));
        Debug.Log("Subtraction: " + (a - b));
        Debug.Log("Multiplication: " + (a * b));
        Debug.Log("Division: " + (a / b));
        Debug.Log("Remainder: " + (a % b));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
