using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class CameraLookAt : MonoBehaviour
{
    public Light light1;
    public Volume volume;
    Vignette vignette;

    public GameObject[] boids;
    public GameObject[] targets;

    public int targetNumber = 0;
    void Start()
    {
        volume.profile.TryGet(out vignette);
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
            vignette.intensity.value = 1;
            
        }
        else if (targetNumber < 2)
        {
            light1.color = new Color32(167, 201, 255, 255);
            light1.intensity = 2;
            vignette.intensity.value = 0;
        }
    }
}
