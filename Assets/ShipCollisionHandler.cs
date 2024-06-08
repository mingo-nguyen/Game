using UnityEngine;
using UnityEngine.SceneManagement; // Only if you need to handle scene transitions

public class ShipCollisionHandler : MonoBehaviour
{
    // This function is called automatically by Unity when the object this script is attached to collides with another object
    void OnCollisionEnter(Collision collision)
    {
        // Log collision for debugging
        Debug.Log("Collision detected with: " + collision.gameObject.name);

        // Call the GameOver function to handle the game over logic
        GameOver();
    }

    // This function handles the game over logic
    void GameOver()
    {
        // Example game over logic
        // You can load a game over scene or show a game over UI
        // SceneManager.LoadScene("GameOverScene"); // Uncomment if you have a game over scene

        // Example: Show a game over message in the console
        Debug.Log("Game Over!");

        // Alternatively, you can trigger any other game over handling logic here
    }
}
