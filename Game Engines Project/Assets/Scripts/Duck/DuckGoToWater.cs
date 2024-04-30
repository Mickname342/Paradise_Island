using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckGoToWater : DuckBaseState
{
    public override void EnterState(DuckStateManager state)
    {
        int number = 0;
        float distance = 1000;
        float prevDistance = 10000;
        for (int i = 0; i < state.borders.Length; i++)
        {
            distance = Vector3.Distance(state.transform.position, state.borders[i].transform.position);

            if (distance < prevDistance)
            {
                prevDistance = distance;
                number = i;
            }
        }
        state.wander.weight = 0;
        state.seek.weight = 1;
        state.seek.targetGameObject = state.borders[number];
    }

    public override void UpdateState(DuckStateManager state)
    {

    }

    public override void OnTriggerEnter(DuckStateManager state, Collider other)
    {
        if (other.CompareTag("Positions"))
        {
            state.SwitchState(state.wanderWater);
        }
    }
}
