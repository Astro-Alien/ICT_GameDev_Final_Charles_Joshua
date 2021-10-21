using UnityEngine;
using UnityEngine.UI;

public class SoundOperations : MonoBehaviour
{
    public AudioSource aod;
    private float soundVolume = 1f;
    public Slider sliderVolume;

    void Start()
    {
        aod.Play();
        soundVolume = PlayerPrefs.GetFloat("gameSound");
        aod.volume = soundVolume;
    }

   
    void Update()
    {
        aod.volume = soundVolume;
        PlayerPrefs.SetFloat("gameSound", soundVolume);
    }
    public void soundUpdate(float sound)
    {

        soundVolume = sound;

    }
   
    

}
