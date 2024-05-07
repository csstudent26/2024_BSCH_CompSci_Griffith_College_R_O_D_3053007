using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;


public class PolicemanController : MonoBehaviour
{
    public Transform[] patrolPoints; // Array of patrol points
    private int currentPatrolIndex = 0; // Index of the current patrol point
    public float moveSpeed = 3f; // Movement speed of the policeman

    void Update()
    {
        // Check if there are patrol points assigned
        if (patrolPoints.Length > 0)
        {
            // Move towards the current patrol point
            transform.position = Vector3.MoveTowards(transform.position, patrolPoints[currentPatrolIndex].position, moveSpeed * Time.deltaTime);

            // Check if the policeman has reached the current patrol point
            if (Vector3.Distance(transform.position, patrolPoints[currentPatrolIndex].position) < 0.1f)
            {
                // Move to the next patrol point
                currentPatrolIndex = (currentPatrolIndex + 1) % patrolPoints.Length;
            }
        }
        else
        {
            Debug.LogWarning("No patrol points assigned to the policeman!");
        }
    }
}
