using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpenLevel : MonoBehaviour
{
    //public Button scene2;
    //int levelComplete;

    //void Start()
    //{
    //    levelComplete = PlayerPrefs.GetInt("LevelComplete");
    //    scene2.interactable = false;

    //    switch(levelComplete)
    //    {
    //        case 1:
    //            scene2.interactable = true;
    //            break;
    //    }
    //}
    public void Level_1()
    {
        SceneManager.LoadScene(1);
    }
    public void Level_2()
    {
        
    }
}
