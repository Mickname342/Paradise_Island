using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyWhaleStateManager : MonoBehaviour
{
    BabyWhaleBaseState currentState;

    public BabyWhalePursueState pursueState = new BabyWhalePursueState();
    public BabyWhaleAvoidState avoidState = new BabyWhaleAvoidState();

    public Pursue pursue;
    public ObstacleAvoidance avoid;
    void Start()
    {
        currentState = pursueState;
        currentState.EnterState(this);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SwitchState(BabyWhaleBaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 8 || other.gameObject.layer == 7)
        {
            currentState.OnTriggerEnter(this, other);
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 8 || other.gameObject.layer == 7)
        {
            currentState.OnTriggerExit(this, other);
        }
    }
}
