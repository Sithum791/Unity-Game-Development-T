using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParameterMethodDemo : MonoBehaviour
{
    // Start is called before the first frame update
    void ShowScore(string playerName, int score)
    {
        Debug.Log(playerName + " scored: " + score);
    }
    void Start()
    {
        ShowScore("Kavindu", 85);
        ShowScore("Nimesh", 95);
    }
}
