using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakLoop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        
        {
            if (i == 4)
            {
                Debug.Log("Breaking at 4");
                break;
            }
            Debug.Log("i = " + i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
