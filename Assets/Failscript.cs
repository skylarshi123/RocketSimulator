using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // Include the UI namespace to work with UI elements.

public class FailScreen : MonoBehaviour
{
    // You can attach these buttons in the inspector by dragging and dropping.
    private void Start()
    {
        // Add listeners for button clicks.
    }

    public void RestartLevel()
    {
        // Reloads the current scene.
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Ensure we do not exceed the number of scenes in our build settings.
        if (currentSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(currentSceneIndex - 1);
        }

    }

    public void EndGame()
    {
        // Quits the application.
        // Note: This will only work in a built game, not in the Unity Editor.
        Application.Quit();
    }
}
