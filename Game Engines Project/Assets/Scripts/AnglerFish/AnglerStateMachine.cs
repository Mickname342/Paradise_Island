using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnglerStateMachine : MonoBehaviour
{
    public GameObject[] anemonae;

    public Seek seek;

    public int random;

    public FishStateManager fish;
    void Start()
    { 
        StartCoroutine(Switch());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Switch()
    {
        while (true)
        {
            yield return new WaitForSeconds(20);
            random = Random.Range(0, anemonae.Length);
            seek.targetGameObject = anemonae[random];
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fish"))
        {
            fish = other.GetComponent<FishStateManager>();
            fish.angler = gameObject;
            fish.Angler();
        }
    }
}
