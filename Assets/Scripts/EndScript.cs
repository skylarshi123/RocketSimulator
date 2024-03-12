using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // Include the UI namespace to work with UI elements.

public class EndScript : MonoBehaviour
{
    [SerializeField] private Button endGameButton;

    private void Start()
    {
        // Add listeners for button clicks.
        endGameButton.onClick.AddListener(Terminate);
    }

    void Terminate()
    {
        // Quits the application.
        // Note: This will only work in a built game, not in the Unity Editor.
        Application.Quit();
    }
}
