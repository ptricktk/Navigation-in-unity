using UnityEngine;
using System.Collections;

public class AgentIntelligence : MonoBehaviour {

    NavMeshAgent agent;

    GameObject[] NavigationPoints;

    Vector3 TargetToReach;
    int LastTargetReached;

    // Use this for initialization
    void Start() {
        agent = GetComponent<NavMeshAgent>();
        NavigationPoints = GameObject.FindGameObjectsWithTag("NavigationPoint");

        TargetToReach = GetRandomDestination();
    }

	// Update is called once per frame
	void Update () {
        agent.SetDestination(TargetToReach);

	}

    Vector3 GetRandomDestination()
    {
        
        int destination = Random.Range(0, NavigationPoints.Length);

        // als nieuwe locatie gelijk is aan huidige, moet er een nieuwe locatie gekozen worden.
        while (destination == LastTargetReached)
        {
            destination = Random.Range(0, NavigationPoints.Length);
            Debug.Log("zelfde locatie afgevangen");
        }
        
        LastTargetReached = destination;
        return NavigationPoints[destination].transform.position;

    }

    public void SetNewDestination()
    {
        TargetToReach = GetRandomDestination();
    }
}
