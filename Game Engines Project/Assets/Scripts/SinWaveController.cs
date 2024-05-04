using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SinWaveController : MonoBehaviour
{
    public Slider frequencySlider;
    public Slider amplitudeSlider;

    public Text frequencyNumber;
    public Text amplitudeNumber;

    public WhaleTail[] anemone;
    public WhaleTail whale;
    public WhaleTail babyWhale;

    int boidSelect = 0;
    void Start()
    {
        frequencySlider.value = anemone[1].frequency;
        frequencyNumber.text = anemone[1].frequency.ToString();
        amplitudeSlider.value = anemone[1].amplitude;
        amplitudeNumber.text = (anemone[1].amplitude * 100).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectBoid(int boid)
    {
        boidSelect = boid;
        switch (boidSelect)
        {
            case 0:
                frequencySlider.value = anemone[1].frequency;
                frequencyNumber.text = anemone[1].frequency.ToString();
                amplitudeSlider.value = anemone[1].amplitude;
                amplitudeNumber.text = (anemone[1].amplitude * 100).ToString();
                break;
            case 1:
                frequencySlider.value = whale.frequency;
                frequencyNumber.text = whale.frequency.ToString();
                amplitudeSlider.value = whale.amplitude;
                amplitudeNumber.text = (whale.amplitude * 100).ToString();
                break;
            case 2:
                frequencySlider.value = babyWhale.frequency;
                frequencyNumber.text = babyWhale.frequency.ToString();
                amplitudeSlider.value = babyWhale.amplitude;
                amplitudeNumber.text = (babyWhale.amplitude * 100).ToString();
                break;
        }
    }

    public void ChangeFrequency(float speed)
    {
        frequencyNumber.text = speed.ToString();
        switch (boidSelect)
        {
            case 0:
                for(int i = 0; i < anemone.Length; i++)
                {
                    anemone[i].frequency = speed;
                }
                break;
            case 1:
                whale.frequency = speed;
                break;
            case 2:
                babyWhale.frequency = speed;
                break;
        }
    }

    public void ChangeAmplitude(float speed)
    {
        amplitudeNumber.text = (speed*100).ToString();
        switch (boidSelect)
        {
            case 0:
                for (int i = 0; i < anemone.Length; i++)
                {
                    anemone[i].amplitude = speed;
                }
                break;
            case 1:
                whale.amplitude = speed;
                break;
            case 2:
                babyWhale.amplitude = speed;
                break;
        }
    }
}
