

using UnityEngine;
using TMPro;

public class PlayerSetup : MonoBehaviour
{
    public float playerSpeed = 100f; // Speed of the player
    private int playerScore = 0; // Player's score
    public TextMeshProUGUI playerScoreText; // Reference to the player's score TextMeshProUGUI element

    void Start()
    {
        // Find the other player GameObject tagged as "Enemy"
        GameObject otherPlayer = GameObject.FindWithTag("Enemy");

        if (otherPlayer != null)
        {
            // Get the direction from the player to the other player
            Vector3 playerDirection = (otherPlayer.transform.position - transform.position).normalized;

            // Set the player's speed in the direction towards the other player
            GetComponent<Rigidbody>().velocity = playerDirection * playerSpeed;
        }
        else
        {
            Debug.LogError("Other player GameObject not found!");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the player's collider is triggered by the other player's collider
        if (other.CompareTag("Enemy"))
        {
            // Increment player's score
            playerScore++;

            // Update the playerScoreText
            UpdatePlayerScoreText();
        }
    }

    void UpdatePlayerScoreText()
    {
        // Update text on the playerScoreText
        if (playerScoreText != null)
        {
            playerScoreText.text = "Player Score: " + playerScore;
        }
    }
}

