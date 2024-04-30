using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckWanderLand : DuckBaseState
{
    public override void EnterState(DuckStateManager state)
    {
        state.noiseWander.weight = 4;
        state.seek.weight = 1;
        state.seek.targetGameObject = state.centre;
    }

    public override void UpdateState(DuckStateManager state)
    {
        if (state.random == 0)
        {
            state.SwitchState(state.stay);
        }
        else if (state.random == 2)
        {
            state.SwitchState(state.goToWater);
        }
    }

    public override void OnTriggerEnter(DuckStateManager state, Collider other)
    {

    }
}
