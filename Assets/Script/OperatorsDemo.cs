using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperatorsDemo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int score = 50;
        int bonus = 25;
        int total = score + bonus;

        Debug.Log("Total Score: " + total);
        Debug.Log("Passed: " + (total >= 75));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
