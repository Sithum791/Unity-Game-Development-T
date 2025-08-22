using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueLoop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        
        {
            if (i == 2)
            {
                continue;
            }
            Debug.Log("i = " + i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
