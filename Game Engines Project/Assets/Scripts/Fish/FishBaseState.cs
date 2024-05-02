using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FishBaseState
{
    public abstract void EnterState(FishStateManager state);

    public abstract void UpdateState(FishStateManager state);

    public abstract void OnTriggerEnter(FishStateManager state, Collider other);

    public abstract void OnTriggerExit(FishStateManager state, Collider other);

    public abstract void SeekAgain(FishStateManager state);

    public abstract void Angler(FishStateManager state);
}
