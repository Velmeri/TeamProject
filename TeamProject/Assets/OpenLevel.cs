using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpenLevel : MonoBehaviour
{
    public void Level_1()
    {
        SceneManager.LoadScene(1);
    }
    public void Level_2()
    {
        SceneManager.LoadScene(3);
    }
    public void Level_3()
    {
        SceneManager.LoadScene(5);
    }
    public void Level_4()
    {
        SceneManager.LoadScene(7);
    }
}
