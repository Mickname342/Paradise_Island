using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedControl : MonoBehaviour
{
    public Text globalSpeed;
    public Text individualSpeed;

    public Slider sliderTime;
    public Slider sliderBoids;

    bool running = true;
    float previosTime = 1;

    int boidSelect = 0;

    public Boid[] ducks;
    public Boid whale;
    public Boid babyWhale;
    public Boid[] fish;
    public Boid anglerFish1;
    public Boid anglerFish2;

    float duckInitialSpeed;
    float whaleInitialSpeed;
    float babyInitialSpeed;
    float fishInitialSpeed;
    float angler1InitialSpeed;
    float angler2InitialSpeed;
    // Start is called before the first frame update
    void Start()
    {
        sliderBoids.value = ducks[0].maxSpeed;
        individualSpeed.text = ducks[0].maxSpeed.ToString();
        duckInitialSpeed = ducks[0].maxSpeed;
        whaleInitialSpeed = whale.maxSpeed;
        babyInitialSpeed = babyWhale.maxSpeed;
        fishInitialSpeed = fish[0].maxSpeed;
        angler1InitialSpeed = anglerFish1.maxSpeed;
        angler2InitialSpeed = anglerFish2.maxSpeed;

        globalSpeed.text = previosTime.ToString();
        sliderTime.value = previosTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (!running)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = previosTime;
        }
    }

    public void ControlSpeed(float speed)
    {
        if (running)
        {
            Time.timeScale = speed;
            previosTime = speed;
            globalSpeed.text = previosTime.ToString();
        }
        
    }

    public void Stop()
    {
        running = !running;
        globalSpeed.text = previosTime.ToString();
    }

    public void ResetTime()
    {
        running = true;
        Time.timeScale = 1;
        previosTime = 1;
        globalSpeed.text = previosTime.ToString();
        sliderTime.value = 1;
    }

    public void SelectBoid(int boid)
    {
        boidSelect = boid;
        switch (boidSelect)
        {
            case 0:
                sliderBoids.value = ducks[0].maxSpeed;
                individualSpeed.text = ducks[0].maxSpeed.ToString();
                break;
            case 1:
                sliderBoids.value = whale.maxSpeed;
                individualSpeed.text = whale.maxSpeed.ToString();
                break;
            case 2:
                sliderBoids.value = babyWhale.maxSpeed;
                individualSpeed.text = babyWhale.maxSpeed.ToString();
                break;
            case 3:
                sliderBoids.value = fish[0].maxSpeed;
                individualSpeed.text = fish[0].maxSpeed.ToString();
                break;
            case 4:
                sliderBoids.value = anglerFish1.maxSpeed;
                individualSpeed.text = anglerFish1.maxSpeed.ToString();
                break;
            case 5:
                sliderBoids.value = anglerFish2.maxSpeed;
                individualSpeed.text = anglerFish2.maxSpeed.ToString();
                break;
        }
    }

    public void IndividualSpeed(float speed)
    {
        individualSpeed.text = speed.ToString();
        switch (boidSelect)
        {
            case 0:
                for(int i = 0; i < ducks.Length; i++)
                {
                    ducks[i].maxSpeed = speed;
                }
                break;
            case 1:
                whale.maxSpeed = speed;
                break;
            case 2:
                babyWhale.maxSpeed = speed;
                break;
            case 3:
                for(int i = 0;i < fish.Length; i++)
                {
                    fish[i].maxSpeed = speed;
                }
                break;
            case 4:
                anglerFish1.maxSpeed = speed;
                break;
            case 5:
                anglerFish2.maxSpeed = speed;
                break;
        }
    }

    public void ResetBoidSpeed()
    {
        switch (boidSelect)
        {
            case 0:
                for (int i = 0; i < ducks.Length; i++)
                {
                    ducks[i].maxSpeed = duckInitialSpeed;
                }
                sliderBoids.value = ducks[0].maxSpeed;
                individualSpeed.text = ducks[0].maxSpeed.ToString();
                break;
            case 1:
                whale.maxSpeed = whaleInitialSpeed;
                sliderBoids.value = whale.maxSpeed;
                individualSpeed.text = whale.maxSpeed.ToString();
                break;
            case 2:
                babyWhale.maxSpeed = babyInitialSpeed;
                sliderBoids.value = babyWhale.maxSpeed;
                individualSpeed.text = babyWhale.maxSpeed.ToString();
                break;
            case 3:
                for (int i = 0; i < fish.Length; i++)
                {
                    fish[i].maxSpeed = fishInitialSpeed;
                }
                sliderBoids.value = fish[0].maxSpeed;
                individualSpeed.text = fish[0].maxSpeed.ToString();
                break;
            case 4:
                anglerFish1.maxSpeed = angler1InitialSpeed;
                sliderBoids.value = anglerFish1.maxSpeed;
                individualSpeed.text = anglerFish1.maxSpeed.ToString();
                break;
            case 5:
                anglerFish2.maxSpeed = angler2InitialSpeed;
                sliderBoids.value = anglerFish2.maxSpeed;
                individualSpeed.text = anglerFish2.maxSpeed.ToString();
                break;
        }
    }

    public void ResetAllBoidSpeed()
    {
        for (int i = 0; i < ducks.Length; i++)
        {
            ducks[i].maxSpeed = duckInitialSpeed;
        }
        
        whale.maxSpeed = whaleInitialSpeed;
        babyWhale.maxSpeed = babyInitialSpeed;
        
        for (int i = 0; i < fish.Length; i++)
        {
            fish[i].maxSpeed = fishInitialSpeed;
        }
        
        anglerFish1.maxSpeed = angler1InitialSpeed;
        anglerFish2.maxSpeed = angler2InitialSpeed;
        
        switch (boidSelect)
        {
            case 0:
                sliderBoids.value = ducks[0].maxSpeed;
                individualSpeed.text = ducks[0].maxSpeed.ToString();
                break;
            case 1:
                sliderBoids.value = whale.maxSpeed;
                individualSpeed.text = whale.maxSpeed.ToString();
                break;
            case 2:
                sliderBoids.value = babyWhale.maxSpeed;
                individualSpeed.text = babyWhale.maxSpeed.ToString();
                break;
            case 3:
                sliderBoids.value = fish[0].maxSpeed;
                individualSpeed.text = fish[0].maxSpeed.ToString();
                break;
            case 4:
                sliderBoids.value = anglerFish1.maxSpeed;
                individualSpeed.text = anglerFish1.maxSpeed.ToString();
                break;
            case 5:
                sliderBoids.value = anglerFish2.maxSpeed;
                individualSpeed.text = anglerFish2.maxSpeed.ToString();
                break;
        }
    }

}
