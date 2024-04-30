using UnityEngine;

public abstract class DuckBaseState
{
    public abstract void EnterState(DuckStateManager state);

    public abstract void UpdateState(DuckStateManager state);

    public abstract void OnTriggerEnter(DuckStateManager state, Collider other);
}
