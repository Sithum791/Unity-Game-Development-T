using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnMethodDemo : MonoBehaviour
{
    // Start is called before the first frame update
    int AddNumbers(int a, int b)
    
    {
        return a + b;
    }
    void Start()
   
    {
        int result = AddNumbers(3, 7);
        Debug.Log("Sum is: " + result);
    }
}
