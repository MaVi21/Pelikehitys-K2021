using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class PrefsHandler : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider volumeSlider;

    // Start is called before the first frame update
    void Start()
    {
        LoadAudioVolumePrefs();
    }

    public void LoadAudioVolumePrefs()
    {        
        float volume = PlayerPrefs.GetFloat("userAudioVolume");
        mixer.SetFloat("userAudioVolume", volume);
        Debug.Log("Mixer volume loaded to " + volume);
        volumeSlider.value = volume;
    }

    public void SetAudioVolumePrefs(float volume)
    {
        Debug.Log("Prefs volume set to: " + volume);
        PlayerPrefs.SetFloat("userAudioVolume", volume);
    }
}
