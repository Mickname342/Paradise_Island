using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhaleTail : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform[] tail_parts;
    [Range(0.0f, 5.0f)]
    public float frequency = 1;
    public float amplitude = 30;
    public float theta = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        for (int i = 0; i < tail_parts.Length; i++)
        {
            if (i > 0)
            {
                tail_parts[i].localPosition = new Vector3(tail_parts[i].localPosition.x,
                tail_parts[i].localPosition.y + Mathf.Sin(Time.time * frequency + theta - i) * amplitude * i / 2,
                tail_parts[i].localPosition.z);
            }
            else
            {
                tail_parts[i].localPosition = new Vector3(tail_parts[i].localPosition.x,
                tail_parts[i].localPosition.y + Mathf.Sin(Time.time * frequency + theta - i) * amplitude * 0.5f / 2,
                tail_parts[i].localPosition.z);
            }
            
        }
    }
}
