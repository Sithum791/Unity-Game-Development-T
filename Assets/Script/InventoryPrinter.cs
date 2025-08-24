using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryPrinter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] inventory = { "Potion", "Shield", "Sword" };

        for (int i = 0; i < inventory.Length; i++)
        
        {
            Debug.Log("Slot " + i + ": " + inventory[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
