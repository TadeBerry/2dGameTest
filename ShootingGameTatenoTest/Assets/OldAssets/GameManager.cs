using UnityEngine;
using TMPro; // Required for TextMeshPro UI
using System.Collections; // Often necessary for other game mechanics

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; // Optional: Makes the manager easily accessible from other scripts
    public TextMeshProUGUI scoreText; // Reference to the UI text object
    private int score; // The actual score value

    void Awake()
    {
        // Optional: Ensures only one instance of GameManager exists
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        score = 0;
        UpdateScoreText(); // Set the initial score display
    }

    // Public method to add points to the score
    public void AddScore(int points)
    {
        score += points; // Add points
        UpdateScoreText(); // Update the UI display
    }

    // Method to update the text on the screen
    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
