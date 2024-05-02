using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BabyWhaleBaseState
{
    public abstract void EnterState(BabyWhaleStateManager state);

    public abstract void UpdateState(BabyWhaleStateManager state);

    public abstract void OnTriggerEnter(BabyWhaleStateManager state, Collider other);

    public abstract void OnTriggerExit(BabyWhaleStateManager state, Collider other);
}
