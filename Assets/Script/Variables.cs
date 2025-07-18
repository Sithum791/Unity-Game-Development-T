using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int score = 100;
        float speed = 5.5f;
        string playerName = "Sithum";

        Debug.Log("Player: " + playerName);
        Debug.Log("Score: " + score);
        Debug.Log("Speed: " + speed);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
