using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueLoopExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= 5; i++)
       
        {
            if (i == 3) continue;
            Debug.Log("i = " + i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
