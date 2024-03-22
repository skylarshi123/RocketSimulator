using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_FuelTracker : MonoBehaviour
{
    public Image fuelBar;
    public float fuelAmount = 100f;

    private void Update()
    {
        if (fuelAmount <= 0)
        {
            Debug.Log("Failed");
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            loseFuel(5);
        }
    }
    public void loseFuel(float fuelLost)
    {
        fuelAmount -= fuelLost;
        fuelBar.fillAmount = fuelAmount / 100f;
    }
}
