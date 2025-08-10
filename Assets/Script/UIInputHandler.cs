using UnityEngine;
using UnityEngine.UI;
public class UIInputHandler : MonoBehaviour
{
    public InputField nameInput;
    public void PrintName()
    {
        string userName = nameInput.text;
        Debug.Log("Hello, " + userName);
    }
}