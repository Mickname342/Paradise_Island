using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhaleStateManager : MonoBehaviour
{
    WhaleBaseState currentState;

    public WhaleSeekState seekState = new WhaleSeekState();
    public WhaleWanderState wanderState = new WhaleWanderState();

    public NoiseWander wander;
    public Seek seek;

    public int random = 0;

    void Start()
    {
        StartCoroutine(RandomGenerator());

        currentState = wanderState;

        currentState.EnterState(this);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(WhaleBaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }

    IEnumerator RandomGenerator()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            random = Random.Range(0, 8);
        } 
    }
}
