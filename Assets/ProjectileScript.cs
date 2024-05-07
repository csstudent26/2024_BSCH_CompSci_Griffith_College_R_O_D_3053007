using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;


public class ProjectileScript : MonoBehaviour
{
    public string shooterTag; // Tag to identify the shooter (player or enemy)
    public TextMeshProUGUI playerScoreText;
    public TextMeshProUGUI enemyScoreText;

     public TextMeshProUGUI welcomeText; // Reference to the TextMeshProUGUI for displaying the welcome message

    // Welcome message variables
    public string welcomeMessage = "Welcome, Player!";
    public float displayTime = 2f;
    private bool welcomed = false;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the projectile collides with an object tagged as "Player" or "Enemy"
        if ((shooterTag == "Player2" && other.CompareTag("Enemy")) || (shooterTag == "Enemy" && other.CompareTag("Player2")))
        {
            // Update scores based on the tag of the collided object
            if (other.CompareTag("Player2"))
            {
                UpdateScore(playerScoreText);
            }
            else if (other.CompareTag("Enemy"))
            {
                UpdateScore(enemyScoreText);
            }

            // Destroy the projectile
            Destroy(gameObject);
        }

        // Check if both player and enemy scores have reached 10 (assuming 10 is the winning score)
        if (int.Parse(playerScoreText.text.Split(':')[1].Trim()) >= 10 || int.Parse(enemyScoreText.text.Split(':')[1].Trim()) >= 10)
        {
            // Determine the winner
            if (int.Parse(playerScoreText.text.Split(':')[1].Trim()) > int.Parse(enemyScoreText.text.Split(':')[1].Trim()))
            {
                Debug.Log("Player2 wins!");
            }
            else if (int.Parse(enemyScoreText.text.Split(':')[1].Trim()) > int.Parse(playerScoreText.text.Split(':')[1].Trim()))
            {
                Debug.Log("Enemy wins!");
            }
            else
            {
                Debug.Log("It's a tie!");
            }

            // End the game (optional)
            // You can perform additional end-game actions here
        }
    }

    private void UpdateScore(TextMeshProUGUI scoreText)
    {
        // Extract score value from the text and increment it
        int score = int.Parse(scoreText.text.Split(':')[1].Trim());
        score++;

        // Update the score text
        scoreText.text = scoreText.text.Split(':')[0] + ": " + score.ToString();
    }
}
