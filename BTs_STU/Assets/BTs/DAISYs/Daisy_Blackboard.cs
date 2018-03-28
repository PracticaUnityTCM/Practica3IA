using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daisy_Blackboard : MonoBehaviour {
    public GameObject[] waypoints;

	// Use this for initialization
	public GameObject GetRandomWaypoint()
    {
        return waypoints[Random.Range(0, waypoints.Length - 1)];
    }
}
