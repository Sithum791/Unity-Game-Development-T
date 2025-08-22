using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthChecker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] healthLevels = { 100, 80, 30, 0, 60 };

        for (int i = 0; i < healthLevels.Length; i++)
        {
            if (healthLevels[i] <= 0)
            {
                Debug.Log("Enemy " + i + " is defeated.");
            }
            else
            {
                Debug.Log("Enemy " + i + " HP: " + healthLevels[i]);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
