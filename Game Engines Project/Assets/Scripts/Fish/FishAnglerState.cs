using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishAnglerState : FishBaseState
{
    public override void EnterState(FishStateManager state)
    {
        state.seek.weight = 2;
        state.seek.targetGameObject = state.angler;
    }

    public override void UpdateState(FishStateManager state)
    {

    }

    public override void OnTriggerEnter(FishStateManager state, Collider other)
    {
        
    }

    public override void OnTriggerExit(FishStateManager state, Collider other)
    {

    }

    public override void SeekAgain(FishStateManager state)
    {
        
    }

    public override void Angler(FishStateManager state)
    {
        
    }
}
