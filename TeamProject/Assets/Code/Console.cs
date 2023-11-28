using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Console : MonoBehaviour
{
    private bool TestMode = true; // пока-что так
    public UnityEngine.UI.InputField commandInput;
    public UnityEngine.UI.Text consoleOutput;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backslash) && TestMode){
            Debug.Log("Backslash pressed");

            commandInput.gameObject.SetActive(!commandInput.gameObject.activeSelf);
            consoleOutput.gameObject.SetActive(!consoleOutput.gameObject.activeSelf);

            if (commandInput.gameObject.activeSelf)
            {
                commandInput.Select();
                commandInput.ActivateInputField();
            }
        }
    }
}
