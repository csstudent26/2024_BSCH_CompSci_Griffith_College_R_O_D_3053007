using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class EnemyShootScript : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform firePoint;
    public float maxDetectionRange = 10f; // Maximum range for player detection
    public LayerMask playerLayer; // Layer mask to filter player objects
    public float shootingInterval = 2f; // Interval between shots
    private float shootingTimer = 0f; // Timer to track time between shots

    private void Update()
    {
        // Update the shooting timer
        shootingTimer += Time.deltaTime;

        // Check if it's time for the enemy to shoot
        if (shootingTimer >= shootingInterval)
        {
            // Check for player detection
            if (DetectPlayer())
            {
                // Aim at the player and shoot
                AimAndShoot();
            }
            
            // Reset the shooting timer
            shootingTimer = 0f;
        }
    }

    private bool DetectPlayer()
    {
        // Cast a ray from the enemy towards the player
        RaycastHit hit;
        if (Physics.Raycast(transform.position, (PlayerPosition() - transform.position).normalized, out hit, maxDetectionRange, playerLayer))
        {
            // Check if the ray hits the player
            if (hit.collider.CompareTag("Player2"))
            {
                return true;
            }
        }
        return false;
    }

    private Vector3 PlayerPosition()
    {
        // Find the position of the player
        GameObject player = GameObject.FindGameObjectWithTag("Player2");
        if (player != null)
        {
            return player.transform.position;
        }
        return Vector3.zero;
    }

    private void AimAndShoot()
    {
        // Calculate the direction to aim at the player
        Vector3 directionToPlayer = (PlayerPosition() - firePoint.position).normalized;

        // Rotate the enemy to aim at the player
        transform.rotation = Quaternion.LookRotation(directionToPlayer, Vector3.up);

        // Shoot
        Shoot();
    }

    private void Shoot()
    {
        // Instantiate a projectile
        GameObject projectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);

        // Apply velocity to the projectile
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        rb.velocity = firePoint.forward * 10f; // Shoot in the direction the enemy is facing
    }
}
