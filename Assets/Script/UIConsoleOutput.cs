using UnityEngine;
using UnityEngine.UI;

public class UIConsoleOutput : MonoBehaviour
{
    public InputField playerInput; 
    public void SubmitName()
    {
        Debug.Log("Player entered: " + playerInput.text);
    }
}
