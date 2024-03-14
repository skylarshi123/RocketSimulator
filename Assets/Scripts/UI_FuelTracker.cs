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
    // Start is called before the first frame update
    /*[SerializeField] Slider slider;
    private float fuel;
    void Start()
    {
        fuel = 100;
    }

    // Update is called once per frame
    void Update()
    {
        SetFuel(GetFuel()-1);
        slider.value = fuel;
    }

    

    public void SetFuel(float amt) {
        fuel = amt;
    }

    public float GetFuel() {
        return fuel;
    }

    // code for a health bar, similar to a fuel tracker

    /*public Slider healthBar;
    public Health playerHealth;
    private void Start()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();
        healthBar = GetComponent<Slider>();
        healthBar.maxValue = playerHealth.maxHealth;
        healthBar.value = playerHealth.maxHealth;
    }
    public void SetHealth(int hp)
    {
        healthBar.value = hp;
    }*/
}
