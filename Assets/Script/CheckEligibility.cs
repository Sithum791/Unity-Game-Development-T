using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckEligibility : MonoBehaviour
{
    // Start is called before the first frame update
    bool IsAdult(int age)
    
    {
        return age >= 18;
    }
    void Start()
   
    {
        bool eligible = IsAdult(20);
        Debug.Log("Is adult: " + eligible);
    }
}
