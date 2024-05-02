using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhaleWanderState : WhaleBaseState
{
    public override void EnterState(WhaleStateManager state)
    {
        state.wander.weight = 2;
        state.pathFollow.weight = 1;
    }

    public override void UpdateState(WhaleStateManager state)
    {
        if (state.random > 5)
        {
            state.SwitchState(state.seekState);
        }
    }

    public override void OnTriggerEnter(WhaleStateManager state)
    {

    }
}
