using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelChecker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int playerLevel = 5;

        if (playerLevel >= 10)
        {
            Debug.Log("Unlocked new ability!");
        }
        else
        {
            Debug.Log("Keep leveling up!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
