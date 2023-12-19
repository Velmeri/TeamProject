
using UnityEngine;
using UnityEngine.UI;


public class Button_Sounds_Controller : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private AudioSource audio_Sound;
    [SerializeField] private Slider slider_Sound;
    //[SerializeField] private Text text_Sounds;

    [Header("Keys")]
    [SerializeField] private string saveVolumeKey_Sound;

    [Header("Tags")]
    [SerializeField] private string sliderTag_Sound;
    //[SerializeField] private string textTag_Sounds;

    [Header("Parametrs")]
    [SerializeField] private float volume_Sound;


    private void Awake()
    {
        //Sounds:
        if (PlayerPrefs.HasKey(this.saveVolumeKey_Sound))
        {
            this.volume_Sound = PlayerPrefs.GetFloat(this.saveVolumeKey_Sound);
            this.audio_Sound.volume = this.volume_Sound;

            GameObject sliderObj = GameObject.FindWithTag(this.sliderTag_Sound);
            if (sliderObj != null)
            {
                this.slider_Sound = sliderObj.GetComponent<Slider>();
                this.slider_Sound.value = this.volume_Sound;
            }
        }
        else
        {
            this.volume_Sound = 0.5f;
            PlayerPrefs.SetFloat(this.saveVolumeKey_Sound, this.volume_Sound);
            this.audio_Sound.volume = this.volume_Sound;
        }
    }

    private void LateUpdate()
    {
        //Sounds:
        GameObject sliderObj = GameObject.FindWithTag(this.sliderTag_Sound);
        if (sliderObj != null)
        {
            this.slider_Sound = sliderObj.GetComponent<Slider>();
            this.volume_Sound = slider_Sound.value;

            if (this.audio_Sound.volume != this.volume_Sound)
            {
                PlayerPrefs.SetFloat(this.saveVolumeKey_Sound, this.volume_Sound);
            }

            //GameObject textObj = GameObject.FindWithTag(this.textTag_Sound);
            //if (textObj != null)
            //{
            //    this.text_Sound = textObj.GetComponent<Text>();
            //    this.text_Sound.text = Mathf.Round(this.volume_Sound * 100) + "%";
            //}
        }
        this.audio_Sound.volume = this.volume_Sound;
    }
}
