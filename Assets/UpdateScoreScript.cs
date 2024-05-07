using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdateScoreScript : MonoBehaviour
{
  public TextMeshProUGUI playerScoreText; // Reference to the player's score TextMeshProUGUI UI element
    private int playerScore = 0;

    // Other methods and logic in your script...

    // Method to update the player's score
    public void UpdatePlayerScore(int scoreIncrement)
    {
        playerScore += scoreIncrement;
        UpdatePlayerScoreText();
    }

    // Update the player's score text on the UI
    private void UpdatePlayerScoreText()
    {
        if (playerScoreText != null)
        {
            playerScoreText.text = "Player's Score: " + playerScore;
        }
    }

    void Update ()
    {
        playerScoreText.text = "Player's Score: " + playerScore;


    }
}
  


