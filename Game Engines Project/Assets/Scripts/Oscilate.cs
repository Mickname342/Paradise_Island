using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscilate : MonoBehaviour
{
    // Start is called before the first frame update
    [Range(0.0f, 5.0f)]
    public float frequency = 0.5f;
    public float amplitude = 1;
    public float theta = 1;
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.localPosition = new Vector3(transform.localPosition.x + Mathf.Sin(Time.time * frequency + theta) * amplitude, transform.localPosition.y, transform.localPosition.z);
    }
}
