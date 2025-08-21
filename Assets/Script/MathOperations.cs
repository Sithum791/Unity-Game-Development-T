using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathOperations : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 15;
        int b = 4;

        Debug.Log("Sum: " + (a + b));
        Debug.Log("Difference: " + (a - b));
        Debug.Log("Product: " + (a * b));
        Debug.Log("Quotient: " + (a / b));
        Debug.Log("Power: " + Mathf.Pow(a, b));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
