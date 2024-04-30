using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckStateManager : MonoBehaviour
{
    DuckBaseState currentState;

    public DuckStay stay = new DuckStay();
    public DuckGoToWater goToWater = new DuckGoToWater();
    public DuckWanderWater wanderWater = new DuckWanderWater();
    public DuckGoToLand goToLand = new DuckGoToLand();
    public DuckWanderLand wanderLand = new DuckWanderLand();

    public NoiseWander noiseWander;
    public Seek seek;
    public Boid boid;

    public GameObject centre;
    public GameObject[] borders;

    public int random;
    public int waterRandom;
    void Start()
    {
        StartCoroutine(RandomGenerator());
        currentState = stay;

        currentState.EnterState(this);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(DuckBaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }

    IEnumerator RandomGenerator()
    {
        while (true)
        {
            yield return new WaitForSeconds(10);
            random = Random.Range(0, 3);
            waterRandom = Random.Range(0, 3);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        currentState.OnTriggerEnter(this, other);
    }
}
