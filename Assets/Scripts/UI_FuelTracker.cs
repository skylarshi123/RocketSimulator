using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UI_FuelTracker : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Slider slider;
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
