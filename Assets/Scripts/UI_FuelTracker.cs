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
        /*int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Ensure we do not exceed the number of scenes in our build settings.
        if (currentSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(currentSceneIndex - 1);
        }*/
        if (fuelAmount <= 0)
        {
            // need to fix this
            //SceneManager.LoadScene(currentSceneIndex);
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
