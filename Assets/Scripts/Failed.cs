using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // Include the UI namespace to work with UI elements.

public class FailScreen : MonoBehaviour
{
    // You can attach these buttons in the inspector by dragging and dropping.

    [SerializeField] private Button restartButton;
    [SerializeField] private Button endGameButton;
    [SerializeField] private Button nextLevelButton;


    private void Start()
    {
        // Add listeners for button clicks.
    }

    public void RestartLevel()
    {
        // Reloads the current scene.
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Ensure we do not exceed the number of scenes in our build settings.
        // if (currentSceneIndex < SceneManager.sceneCountInBuildSettings)
        // {
            SceneManager.LoadScene(currentSceneIndex - 1);
        // }
        // else
        //     SceneManager.LoadScene(currentSceneIndex);

    }

    public void EndGame()
    {
        // Quits the application.
        // Note: This will only work in a built game, not in the Unity Editor.
        Application.Quit();
    }

    public void NextLevel()
    {
        // Loads the next level based on the current scene's build index.
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;
        SceneManager.LoadScene(nextSceneIndex);
        // // Check if the next scene index exceeds the number of scenes in Build Settings.
        // if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        // {
        //     SceneManager.LoadScene(nextSceneIndex);
        // }
        // else
        // {
        //     Debug.Log("Last level reached. No more levels to load.");
        //     // Optionally, loop back to the first level or show a game over screen.
        // }
    }
}
