using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoopDemo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int count = 5;
        while (count > 0)
        
        {
            Debug.Log("Countdown: " + count);
            count--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
