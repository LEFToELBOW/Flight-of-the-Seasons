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
        StartCoroutine(WaitAndChange());
        
    }
    void Update()
    {
        if (timerIsRunning)
        {
            CheckEndGame();
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
    void CheckEndGame()
    {
        if(timerIsRunning)
        {
            if(this.transform.position == endGame.transform.position)
            {
                timerIsRunning = false;
                timeText.text = "";

            }
        }
        
    }
    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    IEnumerator WaitAndChange()
    {
        timeText.text = "";
        info.text = "In this game, you must look around the different subworlds and look for the key to slow the effects of climate change. The keys are under the ground, and proximity is given through pressing E which will bring up a color based on how far you are from the key based on the darkness of the color, dark red means that you have found it and automatically collects the key for you. You must collect all of the keys under the time limit using the portals around you to move inside of the worlds faster. Good Luck";

        yield return new WaitForSeconds(20);

        info.text = "Time Remaining:";
        timerIsRunning = true;
    }
}