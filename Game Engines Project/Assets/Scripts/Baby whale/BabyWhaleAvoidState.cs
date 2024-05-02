using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyWhaleAvoidState : BabyWhaleBaseState
{
    public override void EnterState(BabyWhaleStateManager state)
    {
        state.pursue.weight = 0;
        state.avoid.weight = 17;
    }

    public override void UpdateState(BabyWhaleStateManager state)
    {

    }

    public override void OnTriggerEnter(BabyWhaleStateManager state, Collider other)
    {

    }

    public override void OnTriggerExit(BabyWhaleStateManager state, Collider other)
    {
        state.SwitchState(state.pursueState);
    }
}
