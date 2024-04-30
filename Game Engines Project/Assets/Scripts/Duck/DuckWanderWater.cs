using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckWanderWater : DuckBaseState
{
    public override void EnterState(DuckStateManager state)
    {
        state.noiseWander.weight = 4;
        state.seek.weight = 1;
    }

    public override void UpdateState(DuckStateManager state)
    {
        if (state.waterRandom == 2)
        {
            state.SwitchState(state.goToLand);
        }
    }

    public override void OnTriggerEnter(DuckStateManager state, Collider other)
    {

    }
}
