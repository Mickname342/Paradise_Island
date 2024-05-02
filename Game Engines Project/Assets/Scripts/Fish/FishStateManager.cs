using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishStateManager : MonoBehaviour
{
    FishBaseState currentState;

    public FishSeekState seekState = new FishSeekState();
    public FishAnglerState anglerState = new FishAnglerState();

    public Seek seek;

    public GameObject angler;
    void Start()
    {
        currentState = seekState;
        currentState.EnterState(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        currentState.OnTriggerEnter(this, other);
    }

    public void StartCountdown()
    {
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        yield return new WaitForSeconds(2);
        currentState.SeekAgain(this);
    }

    public void Angler()
    {
        currentState.Angler(this);
    }

    public void SwitchState(FishBaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }

    public void Destroy()
    {
        Destroy(gameObject.transform.parent.gameObject);
    }
}
