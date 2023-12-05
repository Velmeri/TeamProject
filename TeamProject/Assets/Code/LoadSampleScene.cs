using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSampleScene : MonoBehaviour
{
    public void Skip()
    {
        SceneTransition.SwitchToScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
