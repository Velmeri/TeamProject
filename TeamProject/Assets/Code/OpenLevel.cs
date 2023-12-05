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
        SceneTransition.SwitchToScene(2);
    }
    public void Level_2()
    {
        SceneTransition.SwitchToScene(3);
    }
    public void Level_3()
    {
        SceneTransition.SwitchToScene(4);
    }
    public void Level_4()
    {
        SceneTransition.SwitchToScene(5);
    }
}
