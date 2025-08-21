using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTypesDemo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int level = 2;
        float health = 95.5f;
        double accuracy = 99.999;
        char initial = 'A';
        bool isAlive = true;

        Debug.Log("Level: " + level);
        Debug.Log("Health: " + health);
        Debug.Log("Accuracy: " + accuracy);
        Debug.Log("Initial: " + initial);
        Debug.Log("Is Alive: " + isAlive);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
