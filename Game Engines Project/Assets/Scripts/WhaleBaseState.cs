using UnityEngine;

public abstract class WhaleBaseState
{
    public abstract void EnterState(WhaleStateManager state);

    public abstract void UpdateState(WhaleStateManager state);

    public abstract void OnTriggerEnter(WhaleStateManager state);
}
