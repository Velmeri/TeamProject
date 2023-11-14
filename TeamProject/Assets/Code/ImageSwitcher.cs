using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ImageSwitcher : MonoBehaviour
{
    public Sprite[] images;
    public Image imageCanvas;
    public float switchInterval = 0.8f;
    public string nextSceneName;

    private int currentIndex = 0;
    private float timer = 0f;

    void Start()
    {
        
    }

    void Update()
    {
        timer += Time.deltaTime;

        if(timer > switchInterval)
        {
            timer = 0f;

            currentIndex = (currentIndex + 1) % images.Length;
            imageCanvas.sprite = images[currentIndex];
        }

        if (currentIndex == 3 && !string.IsNullOrEmpty(SceneManager.GetActiveScene().name))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
