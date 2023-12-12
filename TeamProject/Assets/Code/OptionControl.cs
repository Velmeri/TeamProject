using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionControl : MonoBehaviour
{
    public Slider slideMusic;
    public Slider slideSounds;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Music()
    {
        AudioListener.volume = slideMusic.value;
    }
    public void Sound()
    {
        AudioListener.volume = slideSounds.value;
    }

    public void SetFullScreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
    public void SetResolution()
    {
        Screen.SetResolution(1920, 1080, Screen.fullScreen);
    }

    public void SaveSettings()
    {

    }
    public void LoadSettings()
    {

    }

}
