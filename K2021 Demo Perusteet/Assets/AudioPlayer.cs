using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioPlayer : MonoBehaviour
{
    public AudioMixer mixer;

    public void setAudioVolume(float vol)
    {
        Debug.Log("Volume: " + vol);
        mixer.SetFloat("userAudioVolume", vol);
    }

}
