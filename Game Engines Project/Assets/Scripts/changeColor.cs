using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    public Material mt;
    public Color32[] colors;
    // Start is called before the first frame update
    void Start()
    {
        mt = gameObject.GetComponent<MeshRenderer>().material;
        colors = new Color32[7]
        {
            new Color32(255, 0, 0, 255), //red
            new Color32(255, 165, 0, 255), //orange
            new Color32(255, 255, 0, 255), //yellow
            new Color32(0, 255, 0, 255), //green
            new Color32(0, 0, 255, 255), //blue
            new Color32(75, 0, 130, 255), //indigo
            new Color32(238, 130, 238, 255), //violet
        };
        StartCoroutine(Cycle());
    }

    // Update is called once per frame
    void Update()
    {

    }

    public IEnumerator Cycle()
    {
        int startColor = 0;
        int endColor = 1;
        //startColor = Random.Range(0, colors.Length);
        //endColor = Random.Range(0, colors.Length);
        while (true)
        {
            for (float interpolant = 0f; interpolant < 1f; interpolant += 0.03f)
            {
                mt.color = Color.Lerp(colors[startColor], colors[endColor], interpolant);
                yield return null;
            }
            startColor = endColor;
            endColor++;
            if (startColor > colors.Length - 1)
            {
                startColor = 0;
            }
            if (endColor > colors.Length - 1)
            {
                endColor = 0;
            }
            
        }
    }
}
