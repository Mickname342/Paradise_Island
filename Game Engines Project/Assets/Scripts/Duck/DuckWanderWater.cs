using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckWanderWater : DuckBaseState
{
    public override void EnterState(DuckStateManager state)
    {
        state.wander.weight = 7f;
        state.seek.weight = 1;
    }

    public override void UpdateState(DuckStateManager state)
    {
        if (state.waterRandom == 2)
        {
            state.SwitchState(state.goToLand);
        }
        if (state.wanderRandom < 6)
        {
            state.seek.weight = 1;
        }
        else if (state.wanderRandom >= 6)
        {
            state.seek.weight = 4;
        }
    }

    public override void OnTriggerEnter(DuckStateManager state, Collider other)
    {

    }
}
