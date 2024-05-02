using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSeekState : FishBaseState
{
    public override void EnterState(FishStateManager state)
    {
        state.seek.weight = 2;
    }

    public override void UpdateState(FishStateManager state)
    {

    }

    public override void OnTriggerEnter(FishStateManager state, Collider other)
    {
        if (other.CompareTag("Anemonae"))
        {
            state.seek.weight = 0;
            state.StartCountdown();
        }
    }

    public override void OnTriggerExit(FishStateManager state, Collider other)
    {

    }

    public override void SeekAgain(FishStateManager state)
    {
        state.seek.weight = 2;
    }
}
