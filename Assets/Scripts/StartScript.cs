using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // Include the UI namespace to work with UI elements.

public class StartScript : MonoBehaviour
{
    // You can attach these buttons in the inspector by dragging and dropping.

    [SerializeField] private Button endGameButton;
    [SerializeField] private Button nextLevelButton;


    private void Start()
    {
        // Add listeners for button clicks.
        endGameButton.onClick.AddListener(Terminate);
        nextLevelButton.onClick.AddListener(StartLevel);
    }


    void Terminate()
    {
        // Quits the application.
        // Note: This will only work in a built game, not in the Unity Editor.
        Application.Quit();
    }

    void StartLevel()
    {
        // Loads the next level based on the current scene's build index.
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;

        // Check if the next scene index exceeds the number of scenes in Build Settings.
        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
        else
        {
            Debug.Log("Last level reached. No more levels to load.");
            // Opt
        }
    }
}