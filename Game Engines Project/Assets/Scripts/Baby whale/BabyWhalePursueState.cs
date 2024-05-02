using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyWhalePursueState : BabyWhaleBaseState
{
    public override void EnterState(BabyWhaleStateManager state)
    {
        state.pursue.weight = 4;
        state.avoid.weight = 0;
    }

    public override void UpdateState(BabyWhaleStateManager state)
    {

    }

    public override void OnTriggerEnter(BabyWhaleStateManager state, Collider other)
    {
        state.SwitchState(state.avoidState);
    }

    public override void OnTriggerExit(BabyWhaleStateManager state, Collider other)
    {
        
    }
}
