using UnityEngine;
using System.Collections;

public class TriggerNewDestination : MonoBehaviour {

	void OnTriggerEnter(Collider ObjectThatBumps)
    {
        ObjectThatBumps.GetComponent<AgentIntelligence>().SetNewDestination();
        
    }

}
