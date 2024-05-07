using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class lastScript : MonoBehaviour
{
   public TextMeshProUGUI playerScoreText; // Reference to the player's score TextMeshProUGUI UI element
   public int playerScore = 0;

void OnTriggerEnter(Collider other)
    {
        // Check if the collider's GameObject has the "Enemy" tag
        if (other.CompareTag("Enemy"))
        {
            // Increment player's score by 1
            playerScore += 1;

            // Update player's score text on UI
            if (playerScoreText != null)
            {
                playerScoreText.text = "Player Score: " + playerScore;
            }
            else
            {
                Debug.LogError("Player score text is not assigned!");
            }
        }
    }
}
