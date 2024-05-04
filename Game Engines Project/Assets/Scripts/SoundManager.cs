using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public Slider slider;
    public Text text;

    public AudioSource audioSource;

    void Start()
    {
        slider.value = audioSource.volume;
        text.text = audioSource.volume.ToString();
    }

    public void ChangeVolume(float volume)
    {
        audioSource.volume = volume;
        text.text = volume.ToString();
    }
}
