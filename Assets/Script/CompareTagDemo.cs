using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompareTagDemo : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("Enemy entered trigger!");
        }
    }
}
