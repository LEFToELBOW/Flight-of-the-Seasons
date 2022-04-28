using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public float timeRemaining = 10;
    public bool timerIsRunning = false;
    public Text timeText;
    public Text info;
    public GameObject endGame;
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
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                timerIsRunning = false;
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timeText.text = "";
                this.GetComponent<CharacterController>().enabled = false;
                this.transform.position = endGame.transform.position;
                this.GetComponent<CharacterController>().enabled = true;
                info.text = "You have not collected all of the keys in time. The Earth will now have to rely on world governments to turn back climate change";
            }
        }
    }
    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}