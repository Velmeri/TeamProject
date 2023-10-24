using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResetScript : MonoBehaviour
{
     public GameObject pauseMenuUI;

     public void Resum()
     {
         Debug.Log("Resume");

         pauseMenuUI.SetActive(false);
         Time.timeScale = 1f;
     }

     public void Reset()
     {
         Time.timeScale = 1f;
         int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
         SceneManager.LoadScene(currentSceneIndex);
     }

     public void Menu()
     {
         Time.timeScale = 1f;
     }
}