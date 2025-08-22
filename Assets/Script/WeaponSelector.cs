using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSelector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string weapon = "Bow";

        switch (weapon)
        {
            case "Sword":
                Debug.Log("Equipped a Sword");
                break;
            case "Bow":
                Debug.Log("Equipped a Bow");
                break;
            case "Staff":
                Debug.Log("Equipped a Staff");
                break;
            default:
                Debug.Log("Unknown weapon");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
