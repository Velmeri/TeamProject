using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bController : MonoBehaviour
{
    public UnityEngine.UI.Button[] buttons;
    private int completedLevels;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateButtons();

        if(Input.GetKeyDown(KeyCode.Space)){
            Debug.Log("Saves deleted");
            PlayerPrefs.SetInt("CompletedLevels", 0);
            completedLevels = 0;
        }
    }

    void UpdateButtons(){
        int bNum = 0;
        completedLevels = PlayerPrefs.GetInt("CompletedLevels", 0);
        int countOfUnlockedButtons = completedLevels;

        foreach (UnityEngine.UI.Button button in buttons)
        {
            if (countOfUnlockedButtons-- >= 0) {
                //Debug.Log("Button" + bNum++ + " is interactable");
                button.interactable = true;
            } else {
                //Debug.Log("Button" + bNum++ + " is noneinteractable");
                button.interactable = false;
            }
        }
    }
}