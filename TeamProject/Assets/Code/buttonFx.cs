using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonFx : MonoBehaviour
{
    //public AudioSource myFx;
    //public AudioClip clickFx;

    //public void HoverSound()
    //{
    //    myFx.PlayOneShot(clickFx);
    //}
    //public void ClickSound()
    //{
    //    myFx.PlayOneShot(clickFx);
    //}

    public AudioSource Sound;


    public void PlaySound()
    {
        Sound.Play();
    }

}
