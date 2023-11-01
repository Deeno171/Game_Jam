using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition_2 : MonoBehaviour
{
    public string nextSceneName; // Name of the scene to transition to.
    public Vector2 triggerPosition; // Position where the transition should be triggered.

    private void Update()
    {
        // Check if the player has reached the trigger position (both X and Y).
        if (transform.position.x <= triggerPosition.x && transform.position.y >= triggerPosition.y)
        {
            // Load the next scene.
            SceneManager.LoadScene(nextSceneName);
        }
    }
}

