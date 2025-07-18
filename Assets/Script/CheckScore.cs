using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int score = 45;
        if (score >= 50)
        {
            Debug.Log("You passed the level!");
        }
        else
        {
            Debug.Log("Try again!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
