using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookAt : MonoBehaviour
{
    public GameObject[] boids;
    public GameObject[] targets;

    public int targetNumber = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(targets[0].transform);
        transform.position = boids[0].transform.position;
    }
}
