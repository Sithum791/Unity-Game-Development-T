using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformLogger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Position: " + transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
