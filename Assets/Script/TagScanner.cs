using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagScanner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] collectibles =
    GameObject.FindGameObjectsWithTag("Collectible");
        foreach (GameObject item in collectibles)
        {
            Debug.Log("Found Collectible: " + item.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
