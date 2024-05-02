using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhaleSeekState : WhaleBaseState
{
    public override void EnterState(WhaleStateManager state)
    {
        state.wander.weight = 0;
        state.pathFollow.weight = 1;
    }

    public override void UpdateState(WhaleStateManager state)
    {
        if (state.random <= 5)
        {
            state.SwitchState(state.wanderState);
        }
    }

    public override void OnTriggerEnter(WhaleStateManager state)
    {

    }
}
