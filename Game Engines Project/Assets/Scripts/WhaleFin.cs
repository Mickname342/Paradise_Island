using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhaleFin : MonoBehaviour
{
    [Range(0.0f, 5.0f)]
    public float frequency = 1;
    public float amplitudey = 30;
    public float amplitudex = 30;
    public float theta = 1;
    public bool left = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!left)
        {
            transform.localRotation = Quaternion.Euler(
                transform.localRotation.x + Mathf.Sin(Time.time * frequency + theta) * amplitudex,
                transform.localRotation.y + Mathf.Sin(Time.time * frequency + theta) * amplitudex,
                transform.localRotation.z + Mathf.Sin(Time.time * frequency + theta) * amplitudey);
        }
        else if (left)
        {
            transform.localRotation = Quaternion.Euler(
                transform.localRotation.x + Mathf.Sin(Time.time * frequency + theta) * amplitudex,
                transform.localRotation.y + Mathf.Sin(Time.time * frequency + theta) * -amplitudex,
                transform.localRotation.z + Mathf.Sin(Time.time * frequency + theta) * -amplitudey);
        }
        
    }
}
