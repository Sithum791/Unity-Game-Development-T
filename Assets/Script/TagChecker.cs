using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagChecker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject target = GameObject.FindWithTag("Player");
        if (target != null)
        {
            Debug.Log("Player Found: " + target.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
