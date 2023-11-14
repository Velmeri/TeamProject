using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject InventoryUI;

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
            if (pauseMenuUI.activeSelf)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
        if (Input.GetKeyDown(KeyCode.Q) && (!pauseMenuUI.activeSelf))
        {
            if (InventoryUI.activeSelf)
            {
                InventoryUI.SetActive(false);
            }
            else
            {
                InventoryUI.SetActive(true);
            }
        }
    }

    public void Resume()
    {
        Debug.Log("Resume");

        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }

    void Pause()
    {
        Debug.Log("Pause");

        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }
}
