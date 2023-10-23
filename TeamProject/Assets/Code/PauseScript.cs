using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public GameObject pauseMenuUI;
    private bool isPaused;
    
    // Start is called before the first frame update
    void Start()
    {
        pauseMenuUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        Debug.Log("Resume");

        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f; // Unpause the game time
        isPaused = false;
    }

    void Pause()
    {
        Debug.Log("Pause");

        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f; // Pause the game time
        isPaused = true;
    }
}
