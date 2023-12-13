using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class AnimalAI : MonoBehaviour
{
    public float minTime = 3.0f; // Minimum time in a state
    public float maxTime = 10.0f; // Maximum time in a state
    public float moveSpeed = 3.5f; // Speed of the animal when moving
    public NavMeshAgent agent; // Reference to the NavMeshAgent
    private Animator anim; // Reference to the Animator component
    private float timer; // Timer to count up to random state change

    private string[] states = { "Idle", "Walk", "Run", "Sit" }; // Possible states

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();

        SetRandomDestination();
        SetRandomState();

        Debug.Log("Animal AI started.");
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= maxTime)
        {
            SetRandomState();
            SetRandomDestination();
            timer = 0;
        }

        // Adjust speed and rotation
        if (agent.hasPath)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(agent.velocity.normalized), Time.deltaTime * 1);
            agent.speed = moveSpeed;
            Debug.Log("Animal is moving. Current speed: " + moveSpeed);
        }

        // Adjust to terrain height
        if (Physics.Raycast(transform.position, -Vector3.up, out RaycastHit hit, 2f))
        {
            transform.position = new Vector3(transform.position.x, hit.point.y, transform.position.z);
            Debug.Log("Adjusted animal height to match terrain.");
        }
    }

    void SetRandomDestination()
    {
        Vector3 randomDirection = Random.insideUnitSphere * 10; // Radius of 10 units
        randomDirection += transform.position;
        NavMesh.SamplePosition(randomDirection, out NavMeshHit navHit, 10, -1);
        agent.SetDestination(navHit.position);
        Debug.Log("New destination set: " + navHit.position);
    }

    void SetRandomState()
    {
        int index = Random.Range(0, states.Length);
        foreach (string state in states)
        {
            anim.SetBool(state, false);
        }
        anim.SetBool(states[index], true);

        // Randomize time until next state change
        maxTime = Random.Range(minTime, maxTime);
        Debug.Log("Transitioning to state: " + states[index] + " for " + maxTime + " seconds.");
    }
}


