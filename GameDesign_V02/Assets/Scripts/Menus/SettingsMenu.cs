using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    // public AudioMixer audioMixer2;
    public void SetMusicVolume(float volume)
    {
        //Debug.Log(volume);
        audioMixer.SetFloat("musicVolume", volume);
    }

    public void SetEffectsVolume(float volume)
    {
        //Debug.Log(volume);
        audioMixer.SetFloat("effectsVolume", volume);
    }
}
