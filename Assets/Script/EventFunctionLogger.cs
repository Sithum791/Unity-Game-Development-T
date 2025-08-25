using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventFunctionLogger : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        Debug.Log("Awake Called");
    }
    void Start()
    {
        Debug.Log("Start Called");
    }
    void Update()
    {
        Debug.Log("Update Called");
    }
}
