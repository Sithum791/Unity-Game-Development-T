using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoopArray : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] enemies = { "Goblin", "Troll", "Dragon" };
        for (int i = 0; i < enemies.Length; i++)
        
        {
            Debug.Log("Enemy: " + enemies[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
