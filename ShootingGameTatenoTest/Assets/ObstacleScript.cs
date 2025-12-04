using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int pointsToAdd = 7;

    private void OnTriggerEnter2D(Collider2D other) // Use OnTriggerEnter2D for 2D games
    {
        if (other.CompareTag("Gun"))
        {
            // Call the AddScore method in the GameManager
            GameManager.Instance.AddScore(pointsToAdd);
            Destroy(gameObject); // Remove the collectible object
        }
    }
}