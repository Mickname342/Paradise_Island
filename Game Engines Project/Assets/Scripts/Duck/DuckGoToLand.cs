using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckGoToLand : DuckBaseState
{
    public override void EnterState(DuckStateManager state)
    {
        state.seek.weight = 4;
        state.noiseWander.weight = 1;
        state.seek.targetGameObject = state.centre;
    }

    public override void UpdateState(DuckStateManager state)
    {

    }

    public override void OnTriggerEnter(DuckStateManager state, Collider other)
    {
        if (other.CompareTag("Island"))
        {
            state.SwitchState(state.wanderLand);
        }
    }
}
