using UnityEngine;
using UnityEngine.UI;

public class OptionControl : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private AudioSource audio_Music;
    [SerializeField] private Slider slider_Music;
    //[SerializeField] private Text text_Music;

    [Header("Keys")]
    [SerializeField] private string saveVolumeKey_Music;

    [Header("Tags")]
    [SerializeField] private string sliderTag_Music;
    //[SerializeField] private string textTag_Music;

    [Header("Parametrs")]
    [SerializeField] private float volume_Music;


    private void Awake()
    {
        //Music:
        if (PlayerPrefs.HasKey(this.saveVolumeKey_Music))
        {
            this.volume_Music = PlayerPrefs.GetFloat(this.saveVolumeKey_Music);
            this.audio_Music.volume = this.volume_Music;

            GameObject sliderObj = GameObject.FindWithTag(this.sliderTag_Music);
            if (sliderObj != null)
            {
                this.slider_Music = sliderObj.GetComponent<Slider>();
                this.slider_Music.value = this.volume_Music;
            }
        }
        else
        {
            //this.volume_Music = 0.5f;
            //PlayerPrefs.SetFloat(this.saveVolumeKey_Music, this.volume_Music);
            //this.audio_Music.volume = this.volume_Music;
        }
    }

    private void LateUpdate()
    {
        //Music:
        GameObject sliderMusicObj = GameObject.FindWithTag(this.sliderTag_Music);
        if (sliderMusicObj != null)
        {
            this.slider_Music = sliderMusicObj.GetComponent<Slider>();
            this.volume_Music = slider_Music.value;

            if (this.audio_Music.volume != this.volume_Music)
            {
                PlayerPrefs.SetFloat(this.saveVolumeKey_Music, this.volume_Music);
            }

            //GameObject textObj = GameObject.FindWithTag(this.textTag_Music);
            //if (textObj != null)
            //{
            //    this.text_Music = textObj.GetComponent<Text>();
            //    this.text_Music.text = Mathf.Round(this.volume_Music * 100) + "%";
            //}
        }
        this.audio_Music.volume = this.volume_Music;
    }


    //public void SetFullScreen(bool isFullscreen)
    //{
    //    Screen.fullScreen = isFullscreen;
    //}
    //public void SetResolution()
    //{
    //    Screen.SetResolution(1920, 1080, Screen.fullScreen);
    //}

    public void SaveSettings()
    {

    }
    public void LoadSettings()
    {

    }

}
