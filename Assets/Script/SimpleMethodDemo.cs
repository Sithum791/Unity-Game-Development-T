using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMethodDemo : MonoBehaviour
{
    // Start is called before the first frame update
    void GreetPlayer()
    {
        Debug.Log("Hello, Unity Developer!");
    }
    void Start()
    {
        GreetPlayer();
    }
}
