
using TMPro;

using UnityEngine;

public class PlayerShootScript : MonoBehaviour
{   

    private int playerScore = 0;
    private int enemyScore = 0;

    public GameObject projectilePrefab;
    public Transform firePoint;
    public int maxProjectiles = 8; // Maximum number of projectiles for each player
    private int remainingProjectiles; // Remaining projectiles for the player


    // Update is called once per frame
    void Update()
    {
         Debug.Log("PlayerShootScript: Update method called.");

         // Player shooting logic
        if (Input.GetKeyDown(KeyCode.Space) && remainingProjectiles > 0)
        {
            Shoot();
            remainingProjectiles--; // Decrement remaining projectiles
        }
    }

    void Shoot()
    {
        // Instantiate a projectile
        GameObject projectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);

        // Apply velocity to the projectile
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        rb.velocity = transform.forward * 10f; // Assuming the player is facing forward

         // Print a message to indicate that the player has shot
        Debug.Log("Player has shot a projectile!");
    }
}
