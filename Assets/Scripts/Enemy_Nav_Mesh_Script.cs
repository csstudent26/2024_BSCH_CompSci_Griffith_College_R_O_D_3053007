using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

public class EnemyNavMeshAI : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent agent;


     void Start()
    {
        // Get the NavMeshAgent component attached to this GameObject
        agent = GetComponent<NavMeshAgent>();

    }


    
    // Update is called once per frame
    void Update()
    {
         // Check if the player reference is not null (i.e., player exists)
        if (player != null)
        {
            // Set the destination of the NavMeshAgent to the player's position
            agent.SetDestination(player.position);
        }


    }
}