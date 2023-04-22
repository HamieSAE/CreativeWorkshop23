using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public int scoreValue = 1; // The amount of score the coin gives
    public Text scoreText; // Reference to the UI text element that displays the score

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Takes the value of scoreValue and adds one to it
            scoreValue = scoreValue++;
            // Update the UI text to display the new score
            scoreText.text = "Score: " + scoreValue;
            // Destroy the coin game object
            Destroy(gameObject);
        }
    }
}
