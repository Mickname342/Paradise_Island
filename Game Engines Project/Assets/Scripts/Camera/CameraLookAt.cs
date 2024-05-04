using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookAt : MonoBehaviour
{
    public Light light1;

    public GameObject[] boids;
    public GameObject[] targets;

    public int targetNumber = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.LookAt(targets[targetNumber].transform);
        transform.position = boids[targetNumber].transform.position; 
    }

    public void ChangeCamera(int val)
    {
        targetNumber = val;
        if (targetNumber > 1)
        {

            light1.color = new Color32(0, 64, 255, 255);
            light1.intensity = 1;
        }
        else if (targetNumber < 2)
        {
            light1.color = new Color32(167, 201, 255, 255);
            light1.intensity = 2;
        }
    }
}
