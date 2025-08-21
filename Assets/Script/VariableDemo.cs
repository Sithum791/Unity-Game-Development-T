using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableDemo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //declare
        int score = 100;
        float speed = 5.5f;
        string playerName = "Alex";

        Debug.Log("Player: " + playerName);
        Debug.Log("Score: " + score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
