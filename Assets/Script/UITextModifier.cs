using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITextModifier : MonoBehaviour
{
    // Start is called before the first frame update
    public Text messageText;
    void Start()
    {
        messageText.text = "Welcome to the Game!";
        messageText.color = Color.green;
        messageText.fontSize = 24;
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
