using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IAPlayerPet : MonoBehaviour {

    public GameObject Player;
    public NavMeshAgent agent;

    public float distance;


	void FixedUpdate () {
        if (Vector3.Distance(Player.transform.position,transform.position)<distance) {
            agent.SetDestination(Player.transform.position);
            //agent.speed = 0;
        }
        else
        {
           // agent.speed = 0;
        }
	}
}
