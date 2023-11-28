using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManipulasjon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddSave() {
        int lvlCount = PlayerPrefs.GetInt("CompletedLevels", 0) + 1;
        if(lvlCount >= 0) {
            Debug.Log("levels count = " + lvlCount);
            PlayerPrefs.SetInt("CompletedLevels", lvlCount);
        } else {
            Debug.Log("levels count = " + 0);
        }
    }

    public void DelSave() {
        int lvlCount = PlayerPrefs.GetInt("CompletedLevels", 0) - 1;
        if(lvlCount <= 9) {
            Debug.Log("levels count = " + lvlCount);
            PlayerPrefs.SetInt("CompletedLevels", lvlCount);
        } else {
            Debug.Log("levels count = " + 9); 
        }
    }

    public void UnlockAll(){
        int lvlCount = 9;
        Debug.Log("levels count = " + lvlCount);
        PlayerPrefs.SetInt("CompletedLevels", lvlCount);
    }

    public void BlockAll(){
        int lvlCount = 0;
        Debug.Log("levels count = " + lvlCount);
        PlayerPrefs.SetInt("CompletedLevels", lvlCount);
    }
}
