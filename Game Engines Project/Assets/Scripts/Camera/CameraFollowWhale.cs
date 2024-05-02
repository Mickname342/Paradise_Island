using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowWhale : MonoBehaviour
{
    public Transform Whale;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Whale.position.x, transform.position.y, Whale.position.z);
    }
}
