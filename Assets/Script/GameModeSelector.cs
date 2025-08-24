using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModeSelector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string gameMode = "Easy";

        switch (gameMode)
       
        {
            case "Easy":
                Debug.Log("Easy Mode Selected");
                break;
            case "Medium":
                Debug.Log("Medium Mode Selected");
                break;
            case "Hard":
                Debug.Log("Hard Mode Selected");
                break;
            default:
                Debug.Log("Unknown Mode");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
