using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    public Transform head;
    public Transform tail;
    [Range(0.0f, 5.0f)]
    public float frequency = 0.5f;
    public float headAmplitude = 40;
    public float tailAmplitude = 60;

    public float theta = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        head.localRotation = Quaternion.AngleAxis(Mathf.Sin(Time.time * frequency + theta) * headAmplitude, Vector3.up);
        tail.localRotation = Quaternion.AngleAxis(Mathf.Sin(Time.time * frequency + theta) * tailAmplitude, Vector3.up);

    }
}
