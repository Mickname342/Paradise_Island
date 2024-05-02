using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedControl : MonoBehaviour
{
    bool running = true;
    float previosTime = 1;
    // Start is called before the first frame update
    void Start()
    {
        
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
        }
        
    }

    public void Stop()
    {
        running = !running; 
    }
}
