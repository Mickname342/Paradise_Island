using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckStay : DuckBaseState
{
    public override void EnterState(DuckStateManager state)
    {
        state.wander.weight = 0;
        state.seek.weight = 0;
        state.seek.targetGameObject = null;
        //state.boid.velocity = new Vector3(0, 0, 0);
    }

    public override void UpdateState(DuckStateManager state)
    {
        state.wander.weight = 0;
        state.seek.weight = 0;
        state.seek.targetGameObject = null;
        state.boid.velocity = new Vector3(0, 0, 0);
        if (state.random == 1)
        {
            state.SwitchState(state.wanderLand);
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
