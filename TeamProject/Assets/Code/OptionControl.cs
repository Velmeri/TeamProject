using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionControl : MonoBehaviour
{
    public Slider slideMusic;


    public Slider slideSounds;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
}
