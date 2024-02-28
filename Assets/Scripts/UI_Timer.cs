using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeRemaining = 10;
    [SerializeField] bool timerIsRunning = false;
    public TextMeshProUGUI timeText;
    
    // function that displays the time, given seconds, in the correct format
    // i.e. 60 secs will be 1:00, 120 secs will be 2:00, and so on
    void DisplayTime(float timeToDisplay)
    {
        // essential stops the timer by adding one more than the given time
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        // correct format
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                // counts down
                timeRemaining -= Time.deltaTime;
                // actually displays the time counting down
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
                // something happens when time runs out, like a "you lost" screen or something - tbd
            }
        }
    }
}
