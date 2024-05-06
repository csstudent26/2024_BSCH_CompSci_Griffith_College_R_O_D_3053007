using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerAdventureScript : MonoBehaviour

{

   public float playerSpeed = 3.5f; // Speed of the player
    public string[] destinationNames = { "Sanctuary1", "Temple", "Sanctuary2", "Temple", "Sanctuary3", "Temple", "Sanctuary4", "Temple" }; // Array of destination names
    private int currentDestinationIndex = 0; // Index of the current destination
    private NavMeshAgent navMeshAgent; // Reference to the NavMeshAgent component

    private void Start()
    {
        // Get reference to the NavMeshAgent component
        navMeshAgent = GetComponent<NavMeshAgent>();

        // Set player speed
        navMeshAgent.speed = playerSpeed;

        // Set initial destination
        SetDestination(currentDestinationIndex);
    } 

     private void OnTriggerEnter(Collider other)
    {
        // Check if the collided GameObject is the current destination
        if (other.gameObject.name == destinationNames[currentDestinationIndex])
        {
            // Move to the next destination
            MoveToNextDestination();
        }
    } 

    private void MoveToNextDestination()
    {
        // Move to the next destination index
        currentDestinationIndex++;

        // If all destinations have been visited, reset to the first destination
        if (currentDestinationIndex >= destinationNames.Length)
        {
            currentDestinationIndex = 0;
        }

        // Set the next destination
        SetDestination(currentDestinationIndex);
    }

     private void SetDestination(int index)
    {
        // Find the destination GameObject by name
        GameObject destination = GameObject.Find(destinationNames[index]);

        // Set destination to the position of the destination GameObject
        if (destination != null)
        {
            navMeshAgent.SetDestination(destination.transform.position);
        }
        else
        {
            Debug.LogWarning("Destination GameObject not found: " + destinationNames[index]);
        }
    }
}

